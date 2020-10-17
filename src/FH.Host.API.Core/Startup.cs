using FH.Host.API.Infrastructure.DB;
using FH.Host.API.Infrastructure.Email;
using FH.Host.API.Infrastructure.LogDB;
using FH.Host.API.Infrastructure.Middleware.ExceptionHandl;
using FH.Host.API.Infrastructure.SqlSugar;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FH.Host.API.Core
{
    public class Startup
    {
        /// <summary>
        /// 版本号
        /// </summary>
        public string Version { get; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string Project_Name { get; }

        /// <summary>
        /// 项目名称_英文
        /// </summary>
        public string Project_Name_English { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            // 设置版本号和项目名称
            Version = Configuration["ProjectInfo:Version"];
            Project_Name = Configuration["ProjectInfo:Project_Name"];
            Project_Name_English = Configuration["ProjectInfo:Project_Name_English"];
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // 注册FangHuaHostDbContext为服务
            services.AddDbContext<FangHuaHostDbContext>();

            // 注册FangHuaHostLogDbContext为服务
            services.AddDbContext<FangHuaHostLogDbContext>();

            // 注册SqlSugar基础方式使用类为服务
            services.AddTransient(typeof(IOwnerRepository<>), typeof(OwnerRepository<>));

            // 注册SqlSugar对日志操作方法的封装类为服务
            services.AddTransient(typeof(ILogRepository<>), typeof(LogRepository<>));

            // 注册邮件服务
            services.AddTransient(typeof(IEmailServices), typeof(EmailServices));

            // 开启SqlSugar
            services.AddSqlSugarSevice();

            // 注册Swagger服务，定义1个或者多个Swagger文档
            services.AddSwaggerGen(s =>
            {
                // 设置Swagger文档相关信息
                s.SwaggerDoc($"FH.Host.App.API", new Info
                {
                    Version = Version,
                    Title = $"{Project_Name} - FH.Host.App.API 默认接口文档",
                    Description = $"{Project_Name_English} - FH.Host.App HTTP/HTTPS API _{Version}",
                    // 服务条款
                    // TermsOfService = "None",
                    License = new License
                    {
                        Name = $"版权所有 ©{Project_Name}",
                        Url = "https://fanghua.host/"
                    }
                });

                s.SwaggerDoc($"FH.Host.Admin.API", new Info
                {
                    Version = Version,
                    Title = $"{Project_Name} - FH.Host.Admin.API 默认接口文档",
                    Description = $"{Project_Name_English} - FH.Host.Admin HTTP/HTTPS API_{Version}",
                    // 服务条款
                    // TermsOfService = "None",
                    License = new License
                    {
                        Name = $"版权所有 ©{Project_Name}",
                        Url = "https://fanghua.host/"
                    }
                });

                #region 读取XML信息

                // 获取XML注释文件的目录
                // var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
                // var xmlPath = System.IO.Path.Combine(AppContext.BaseDirectory, xmlFile);
                var basePath = Path.GetDirectoryName(typeof(Program).Assembly.Location);// 获取应用程序所在目录（绝对，不受工作目录影响，建议采用此方法获取路径）
                // 添加接口XML的路径
                var xmlPath = Path.Combine(basePath, "ExegesisXmlFile/FH.Host.API.Application.xml");
                // 定义实体类XML的路径
                var entityXmlPath = Path.Combine(basePath, "ExegesisXmlFile/FH.Host.API.Model.xml");

                // 启动XML注释
                s.IncludeXmlComments(xmlPath, true);
                s.IncludeXmlComments(entityXmlPath, true);

                #endregion 读取XML信息

                #region Token绑定到ConfigureServices

                //添加Header验证信息
                //s.OperationFilter<SwaggerHeader>();
                var security = new Dictionary<string, IEnumerable<string>> { { "FH.Host.API", new string[] { } } };
                s.AddSecurityRequirement(security);

                s.AddSecurityDefinition("FH.Host.API", new ApiKeyScheme
                {
                    Description = "JWT授权(数据将在请求头中进行传输) 直接在下框中输入Bearer {token}（注意两者之间是一个空格）\"",
                    Name = "Authorization",//jwt默认的参数名称
                    In = "header",//jwt默认存放Authorization信息的位置(请求头中)
                    Type = "apiKey"
                });

                #endregion Token绑定到ConfigureServices
            });

            // 配置跨域
            services.AddCors(corsOption =>
            {
                corsOption.AddPolicy("CustomCorsPolicy",
                     CorsPolicyBuilder => CorsPolicyBuilder
                    .AllowAnyOrigin() // 允许任何主机请求
                    .AllowAnyMethod() // 允许任何请求方式
                    .AllowAnyHeader() // 允许任何请求头
                                      // .AllowCredentials() //指定处理cookie
                    );
            });

            // 添加Jwt验证
            services.AddAuthentication(options =>
            {
                // 设置默认使用jwt验证方式
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    // 验证接收者
                    ValidateAudience = true,
                    // 验证发布者
                    ValidateIssuer = true,
                    // 验证过期时间
                    ValidateLifetime = true,
                    // 验证秘钥
                    ValidateIssuerSigningKey = true,
                    // 读配置Issure 发行人
                    ValidIssuer = Configuration["Authentication:Issuer"],
                    // 读配置Audience 订阅人
                    ValidAudience = Configuration["Authentication:Audience"],
                    // 设置生成token的秘钥
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Authentication:SecurityKey"])),
                    ClockSkew = TimeSpan.Zero,
                    RequireExpirationTime = true
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, FangHuaHostDbContext context, ILoggerFactory logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // 根据Migrations修改/创建数据库
            new DbInitializer().InitializeAsync(context);

            // 开启全局异常处理捕获
            app.UseMiddleware(typeof(ExceptionHandlerMiddleware));

            // 开启跨域
            app.UseCors("CustomCorsPolicy");

            // 启用Jwt验证
            app.UseAuthentication();

            // 启用Log4Net
            logger.AddLog4Net();

            app.UseHttpsRedirection();

            app.UseMvc();

            // 启用Swagger中间件
            app.UseSwagger();
            // 启用Swagger UI中间件（html css js等），定义Swagger Json 入口
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint($"/swagger/FH.Host.App.API/swagger.json", $"{Project_Name_English} - FH.Host.App HTTP/HTTPS API");
                s.SwaggerEndpoint($"/swagger/FH.Host.Admin.API/swagger.json", $"{Project_Name_English} - FH.Host.Admin HTTP/HTTPS API");

                // 要在应用的根 (http://localhost:&lt;port&gt;/) 处提供 Swagger UI，请将 RoutePrefix 属性设置为空字符串：
                s.RoutePrefix = string.Empty;
            });
        }
    }
}
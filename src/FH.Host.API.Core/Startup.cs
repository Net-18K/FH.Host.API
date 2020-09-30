using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FH.Host.API.Infrastructure.DB;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

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

                // 获取XML注释文件的目录
                // var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
                // var xmlPath = System.IO.Path.Combine(AppContext.BaseDirectory, xmlFile);
                var basePath = Path.GetDirectoryName(typeof(Program).Assembly.Location);// 获取应用程序所在目录（绝对，不受工作目录影响，建议采用此方法获取路径）
                // 添加接口XML的路径
                var xmlPath = Path.Combine(basePath, "FH.Host.API.Application.xml");
                // 定义实体类XML的路径
                var entityXmlPath = Path.Combine(basePath, "FH.Host.API.Model.xml");

                // 启动XML注释
                s.IncludeXmlComments(xmlPath,true);
                s.IncludeXmlComments(entityXmlPath, true);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, FangHuaHostDbContext context)
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

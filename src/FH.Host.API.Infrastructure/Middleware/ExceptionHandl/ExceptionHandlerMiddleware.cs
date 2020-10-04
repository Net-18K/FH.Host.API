using FH.Host.API.Infrastructure.AppConfigurtaion;
using FH.Host.API.Infrastructure.BaiduTranslator;
using FH.Host.API.Infrastructure.Log4Net;
using FH.Host.API.Infrastructure.Model;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace FH.Host.API.Infrastructure.Middleware.ExceptionHandl
{
    /// <summary>
    /// 全局异常捕获中间件
    /// </summary>
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _requestDelegate;

        public ExceptionHandlerMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _requestDelegate(httpContext);
            }
            catch (Exception e)
            {
                await HandleExceptionAsync(httpContext, e);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext httpContext, Exception e)
        {
            if (e == null) return;
            Log4NetHelper.Error(e.Source, e.GetBaseException());
            await WriteExceptionAsync(httpContext, e).ConfigureAwait(false);
        }

        private static async Task WriteExceptionAsync(HttpContext httpContext, Exception e)
        {
            if (e is UnauthorizedAccessException)
            {
                httpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
            }
            else if (e is Exception)
            {
                httpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            httpContext.Response.ContentType = "application/json";
            // 把异常信息通过百度翻译再返回出去
            var resultDto = await BaiduTranslatorService.Translator(e.GetBaseException().Message);
            // 由于Get请求可能出现Url过长,获取不到数据,所以采用Post请求再翻译一次
            if (resultDto.Trans_Result == null)
            {
                resultDto = await BaiduTranslatorService.TranslatorPost(e.GetBaseException().Message);
            }
            // 异常信息返回格式 [zh]：中文 [en]英文
            await httpContext.Response
                .WriteAsync(JsonConvert.SerializeObject(new ResultDto()
                {
                    Success = false,
                    ResultInfo = string.Format("【{0}】温馨提示：[{1}]：{2} [{3}]：{4}",
                        AppConfigurtaionService.Configuration["ProjectInfo:Project_Name"],
                        resultDto.To, resultDto.Trans_Result[0].Dst, resultDto.From, resultDto.Trans_Result[0].Src),
                    StatusCode = httpContext.Response.StatusCode
                })).ConfigureAwait(false);
        }
    }
}
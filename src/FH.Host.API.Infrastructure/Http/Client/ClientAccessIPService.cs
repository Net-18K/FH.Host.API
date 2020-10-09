using FH.Host.API.Infrastructure.AppConfigurtaion;
using FH.Host.API.Infrastructure.Http.Client.Dto;
using Newtonsoft.Json;

namespace FH.Host.API.Infrastructure.Http.Client
{
    /// <summary>
    /// 当前客户端IP服务
    /// </summary>
    public static class ClientAccessIPService
    {
        /// <summary>
        /// 得到当前客户端IP地址信息
        /// </summary>
        /// <returns></returns>
        public static ClientAccessIPResultDto GetClientAccessIP()
        {
            var result = HttpRequestService.HttpGet(AppConfigurtaionService.Configuration["ClientAccessIPAPIUrl"]).ToString();
            // 移除最后面的分号
            // 取得命名后面的Json对象字符串
            return JsonConvert.DeserializeObject<ClientAccessIPResultDto>(result.Remove(result.LastIndexOf(";")).Substring("var returnCitySN = ".Length));
        }
    }
}
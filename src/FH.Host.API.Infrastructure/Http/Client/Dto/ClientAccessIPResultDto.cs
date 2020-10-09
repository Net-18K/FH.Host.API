namespace FH.Host.API.Infrastructure.Http.Client.Dto
{
    /// <summary>
    /// 当前客户端IP返回结果
    /// </summary>
    public class ClientAccessIPResultDto
    {
        /// <summary>
        /// IP地址
        /// </summary>
        public string CIP { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        public string CID { get; set; }

        /// <summary>
        /// 省市
        /// </summary>
        public string CName { get; set; }
    }
}
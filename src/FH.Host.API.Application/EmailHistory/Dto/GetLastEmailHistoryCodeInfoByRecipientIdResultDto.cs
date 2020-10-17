using FH.Host.API.Infrastructure.Model;
using System;

namespace FH.Host.API.Application.EmailHistory.Dto
{
    /// <summary>
    /// 根据收件人账号得到最后一个邮件的验证码信息返回结果
    /// </summary>
    public class GetLastEmailHistoryCodeInfoByRecipientIdResultDto : ResultDto
    {
        /// <summary>
        /// 收件人账号
        /// </summary>
        public string RecipientId { get; set; }

        /// <summary>
        /// 邮件验证码
        /// </summary>
        public string EmailCode { get; set; } = null;

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
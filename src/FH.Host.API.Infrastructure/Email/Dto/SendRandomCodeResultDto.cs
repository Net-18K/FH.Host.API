using System;

namespace FH.Host.API.Infrastructure.Email.Dto
{
    /// <summary>
    /// 发送验证码邮件返回信息类
    /// </summary>
    public class SendRandomCodeResultDto
    {
        /// <summary>
        /// 收件人账号
        /// </summary>
        public string RecipientId { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        public string RandomCode { get; set; }

        /// <summary>
        /// 邮件内容
        /// </summary>
        public string RecipientBody { get; set; }

        /// <summary>
        /// 是否发送成功
        /// </summary>
        public bool IsSendSuccess { get; set; } = true;

        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime SendDate { get; set; } = DateTime.Now;
    }
}
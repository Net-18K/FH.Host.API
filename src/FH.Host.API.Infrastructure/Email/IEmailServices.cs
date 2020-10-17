using FH.Host.API.Infrastructure.Email.Dto;

namespace FH.Host.API.Infrastructure.Email
{
    /// <summary>
    /// 邮件服务接口
    /// </summary>
    public interface IEmailServices
    {
        /// <summary>
        /// 验证码生成
        /// </summary>
        /// <returns>验证码</returns>
        string RandomCode();

        /// <summary>
        /// 发送QQ邮件
        /// </summary>
        /// <param name="RecipientId">收件人邮箱账号</param>
        /// <param name="RecipientBody">邮件内容</param>
        string SendQQEmail(string recipientId, string recipientBody);

        /// <summary>
        /// 发送验证码QQ邮件
        /// </summary>
        /// <param name="RecipientId">收件人邮箱账号</param>
        SendRandomCodeResultDto SendRandomCodeQQEmail(string recipientId);
    }
}
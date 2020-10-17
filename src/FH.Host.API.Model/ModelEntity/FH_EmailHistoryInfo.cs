using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FH.Host.API.Model.ModelEntity
{
    public class FH_EmailHistoryInfo : Entity
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EHID { get; set; }

        /// <summary>
        /// 收件人账号
        /// </summary>
        [Required]
        public string RecipientId { get; set; }

        /// <summary>
        /// 邮件内容
        /// </summary>
        [Required]
        public string EmailBody { get; set; }

        /// <summary>
        /// 邮件验证码
        /// </summary>
        public string EmailCode { get; set; } = null;
    }
}
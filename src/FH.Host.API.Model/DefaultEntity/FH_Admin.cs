using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FH.Host.API.Model.DefaultEntity
{
    /// <summary>
    /// 管理员信息
    /// </summary>
    public class FH_Admin : Entity
    {
        /// <summary>
        /// ID
        /// </summary>
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// 管理员账号
        /// </summary>
        [Required]
        public string AdminName { get; set; }

        /// <summary>
        /// 管理员密码
        /// </summary>
        [Required]
        public string AdminPwd { get; set; }
    }
}
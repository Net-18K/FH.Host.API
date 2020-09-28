using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FH.Host.API.Model.DefaultEntity
{
    /// <summary>
    /// 用户信息
    /// </summary>
    public class FH_Users : Entity
    {
        /// <summary>
        /// ID
        /// </summary>
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// 用户账号
        /// </summary>
        [Required]
        public string UserName { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        [Required]
        public string UserPwd { get; set; }
    }
}

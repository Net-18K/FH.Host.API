using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FH.Host.API.Model
{
    /// <summary>
    /// 默认Entity类
    /// </summary>
    public class Entity
    {
        /// <summary>
        /// 是否删除 0未删除 1已删除
        /// </summary>
        [Required]
        public int IsDeleted { get; set; } = 0;

        /// <summary>
        /// 创建用户ID
        /// </summary>
        [Required]
        public int CreateUserID { get; set; } = 0;

        /// <summary>
        /// 创建管理员ID
        /// </summary>
        [Required]
        public int CreateAdminID { get; set; } = 0;

        /// <summary>
        /// 创建时间
        /// </summary>
        [Required]
        public DateTime CreateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 最后一次修改时间
        /// </summary>
        [Required]
        public DateTime LastUpdateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 软删除时间于备注
        /// </summary>
        public string DeleteTimeAndRemark { get; set; } = null;
    }
}

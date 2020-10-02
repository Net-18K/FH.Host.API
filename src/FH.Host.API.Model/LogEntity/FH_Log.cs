using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FH.Host.API.Model.LogEntity
{
    public class FH_Log
    {
        /// <summary>
        /// ID
        /// </summary>
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// 日志时间
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// 线程ID
        /// </summary>
        public int Thread { get; set; }

        /// <summary>
        /// 日志级别
        /// </summary>
        [MaxLength(50)]
        public string Level { get; set; }

        /// <summary>
        /// 日志对象
        /// </summary>
        public string Logger { get; set; }

        /// <summary>
        /// 日志内容
        /// </summary>
        [MaxLength(5000)]
        public string Message { get; set; }

        /// <summary>
        /// 异常信息
        /// </summary>
        [MaxLength(5000)]
        public string Exception { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jianyiaspnetcore.Models
{
    /// <summary>
    /// 待办事项
    /// </summary>
    public class TodoItem
    {
        /// <summary>
        /// 标识
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 该事项是否已完成
        /// </summary>
        public bool IsDon { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        public DateTimeOffset? DueAt { get; set; }
    }
}

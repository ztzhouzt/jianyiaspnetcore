using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jianyiaspnetcore.Models
{
    /// <summary>
    /// 待办事项视图模型
    /// </summary>
    public class TodoViewModel
    {
        public TodoItem[] Items { get; set; }
    }
}

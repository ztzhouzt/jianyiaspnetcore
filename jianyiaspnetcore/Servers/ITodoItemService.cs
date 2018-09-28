using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jianyiaspnetcore.Models;

namespace jianyiaspnetcore.Servers
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync();

        /// <summary>
        /// 添加待办事项
        /// </summary>
        /// <param name="newItem"></param>
        /// <returns></returns>
        Task<bool> AddItemAsync(TodoItem newItem);
    }
}

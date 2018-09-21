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
    }
}

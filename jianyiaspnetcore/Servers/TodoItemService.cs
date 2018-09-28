using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jianyiaspnetcore.Models;
using Microsoft.EntityFrameworkCore;

namespace jianyiaspnetcore.Servers
{
    public class TodoItemService : ITodoItemService
    {
        private readonly ApplicationDbContext _context;

        public TodoItemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TodoItem[]> GetIncompleteItemsAsync(ApplicationUser user)
        {
            var items = await _context.items
                .Where(x => x.IsDon == false && x.UserId == user.Id)
                .ToArrayAsync();

            return items;
        }

        /// <summary>
        /// 添加待办事项
        /// </summary>
        /// <param name="newItem"></param>
        /// <returns></returns>
        public async Task<bool> AddItemAsync(TodoItem newItem,ApplicationUser user)
        {
            newItem.Id = Guid.NewGuid();
            newItem.IsDon = false;
            newItem.DueAt = DateTimeOffset.Now.AddDays(3);
            newItem.UserId = user.Id;
            _context.items.Add(newItem);

            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }

    }
}

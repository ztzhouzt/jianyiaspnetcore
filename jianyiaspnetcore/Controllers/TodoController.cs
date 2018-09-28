using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jianyiaspnetcore.Models;
using jianyiaspnetcore.Servers;
using Microsoft.AspNetCore.Mvc;

namespace jianyiaspnetcore.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        public async Task<IActionResult> Index()
        {
            var item = await _todoItemService.GetIncompleteItemsAsync();

            var model = new TodoViewModel
            {
                Items = item
            };
            return View(model);
        }

        /// <summary>
        /// 添加待办事项
        /// </summary>
        /// <param name="newItem"></param>
        /// <returns></returns>
        public async Task<IActionResult> AddItem(TodoItem newItem)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            var successful = await _todoItemService.AddItemAsync(newItem);
            if (!successful)
            {
                return BadRequest(new { error = "Could not add item." });
            }
            return RedirectToAction("Index");
        }
    }
}
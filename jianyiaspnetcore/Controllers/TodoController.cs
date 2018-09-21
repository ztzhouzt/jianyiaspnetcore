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
    }
}
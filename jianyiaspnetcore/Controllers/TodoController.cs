using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jianyiaspnetcore.Models;
using jianyiaspnetcore.Servers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace jianyiaspnetcore.Controllers
{
    [Authorize]
    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;
        private readonly UserManager<ApplicationUser> _userManager;

        public TodoController(ITodoItemService todoItemService, UserManager<ApplicationUser> userManager)
        {
            _todoItemService = todoItemService;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null) return Challenge();

            var item = await _todoItemService.GetIncompleteItemsAsync(currentUser);

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
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null) return Challenge();

            var successful = await _todoItemService.AddItemAsync(newItem,currentUser);
            if (!successful)
            {
                return BadRequest(new { error = "Could not add item." });
            }
            return RedirectToAction("Index");
        }
    }
}
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Todo.Api.Models;

namespace Todo.Api.Services
{
    public class TodoRepository : ITodoRepository
    {
        [HttpGet]
        public IActionResult GetTodos()
        {
            var result = TodoRepository.GetAllTodoItems();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        private List<TodoItems> _items = new List<TodoItems>()
        {
            new TodoItem{ Id = 1, Action="Thing one.", IsDone=true},
            new TodoItem{ Id = 2, Action="Thing two.", IsDone=false},
        };

        public IEnumerable<TodoItem> GetAllTodoItems()
        {
            return_items;
        }
    }
}
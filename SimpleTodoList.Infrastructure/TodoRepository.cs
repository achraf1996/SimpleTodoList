using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleTodoList.Domain.Models;
using SimpleTodoList.Infrastructure;
using SimpleTodoList.Infrastructure.DI;

namespace SimpleTodoList.Logic
{
    internal class TodoRepository : ITodoRepository
    {
        private readonly ToDoDbContext _toDoDbContext;

        public TodoRepository(ToDoDbContext doDbContext)
        {
            _toDoDbContext = doDbContext;
        }

        public Task<TodoItem> GetTodoItem(int id)
        {
            return _toDoDbContext.toDoItems.FirstOrDefaultAsync(todo => todo.Id == id);
        }
        public IEnumerable<TodoItem> GetAllTodoItems()
        {
            return _toDoDbContext.toDoItems;
        }

    }
}

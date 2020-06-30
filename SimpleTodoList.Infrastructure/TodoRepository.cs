using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleTodoList.Domain.Models;
using SimpleTodoList.Infrastructure.DI;

namespace SimpleTodoList.Logic
{
    internal class TodoRepository : ITodoRepository
    {
        ToDoDbContext toDoDbContext;

        public TodoRepository(ToDoDbContext doDbContext)
        {
            toDoDbContext = doDbContext;
        }

        public Task<TodoItem> GetTodoItem(int id)
        {
            return toDoDbContext.toDoItems.FirstOrDefaultAsync(todo => todo.Id == id);
        }
        public IEnumerable<TodoItem> GetAllTodoItems()
        {
            return toDoDbContext.toDoItems;
        }

    }
}

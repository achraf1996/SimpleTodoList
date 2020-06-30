using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleTodoList.Domain.Models;

namespace SimpleTodoList.Infrastructure
{
    public interface ITodoRepository
    {
        IEnumerable<TodoItem> GetAllTodoItems();
        Task<TodoItem> GetTodoItem(int id);
    }
}
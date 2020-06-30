using SimpleTodoList.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleTodoList.Logic
{
    public interface ITodoItemsService
    {
        Task<Result<TodoItem>> GetTodoItemByIdAsync(int id);
        Result<List<TodoItem>> GetTodoItems();
    }
}
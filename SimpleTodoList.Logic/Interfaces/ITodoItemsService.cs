using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleTodoList.Domain.Models;

namespace SimpleTodoList.Logic
{
    public interface ITodoItemsService
    {
        Task<Result<TodoItem>> GetTodoItemByIdAsync(int id);
        Result<List<TodoItem>> GetTodoItems();
    }
}
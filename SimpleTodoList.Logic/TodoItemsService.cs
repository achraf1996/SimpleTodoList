using System.Threading.Tasks;
using SimpleTodoList.Domain.Models;
using SimpleTodoList.Infrastructure;

namespace SimpleTodoList.Logic
{
    public class TodoItemsService 
    {
        ITodoRepository todoRepository;

        public TodoItemsService(ITodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        public async Task<Result<TodoItem>> GetTodoItemByIdAsync(int id)
        {
           return Result.Ok<TodoItem>(await todoRepository.GetTodoItem(id));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleTodoList.Domain.Models;
using SimpleTodoList.Infrastructure;

namespace SimpleTodoList.Logic
{
    public class TodoItemsService : ITodoItemsService
    {
        readonly ITodoRepository _todoRepository;

        public TodoItemsService(ITodoRepository todoRepository)
        {
            this._todoRepository = todoRepository;
        }

        public async Task<Result<TodoItem>> GetTodoItemByIdAsync(int id)
        {
            try
            {
                var result = await _todoRepository.GetTodoItem(id);
                return result is null ? Result.Fail<TodoItem>("No item found with this id.") :
                    Result.Ok(result);
            }
            catch (Exception e)
            {
                return Result.Fail<TodoItem>("Error while reading " + e.Message);
            }
        }
        public Result<List<TodoItem>> GetTodoItems()
        {
            try
            {
                var result = _todoRepository.GetAllTodoItems().ToList();
                return result is null ? Result.Fail<List<TodoItem>>("No item found with this id.") :
                    Result.Ok(result);
            }
            catch (Exception e)
            {
                return Result.Fail<List<TodoItem>>("Error while reading " + e.Message);
            }
        }
    }
}
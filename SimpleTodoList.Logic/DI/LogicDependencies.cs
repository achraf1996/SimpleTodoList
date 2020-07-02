using Microsoft.Extensions.DependencyInjection;

namespace SimpleTodoList.Logic.DI
{
    public static class LogicDependencies
    {
        public static void RegisterLogicDependencies(this IServiceCollection services)
        {
            services.AddScoped<ITodoItemsService, TodoItemsService>();
        }
    }
}
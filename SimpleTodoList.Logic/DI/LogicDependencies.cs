using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleTodoList.Logic.DI
{
    public static class LogicDependencies
    {
        public  static void RegisterLogicDependencies(this IServiceCollection services)
        {
            services.AddScoped<ITodoItemsService,TodoItemsService>();
        }
    }
}

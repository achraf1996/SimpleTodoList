﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleTodoList.Infrastructure.DI
{
    public static class InfrastructureDependencies
    {
        public  static void RegisterInfrastructureDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ToDoDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("mainDatabase")));
        }
    }
}
using Microsoft.EntityFrameworkCore;
using SimpleTodoList.Domain.Models;

namespace SimpleTodoList.Infrastructure.DI
{
    internal class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options)
        {}

        DbSet<ToDoItem> toDoItems;
    }
}
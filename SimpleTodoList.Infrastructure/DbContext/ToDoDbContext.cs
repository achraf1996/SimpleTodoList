using Microsoft.EntityFrameworkCore;
using SimpleTodoList.Domain.Models;

namespace SimpleTodoList.Infrastructure.DI
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options)
        {}

        public DbSet<TodoItem> toDoItems;
    }
}
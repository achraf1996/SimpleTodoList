using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleTodoList.Domain.Models
{
    [Table(nameof(TodoItem))]
    public class TodoItem
    {
        [Key] public int Id { get; set; }

        [MaxLength(255)] public string title { get; set; }

        public string description { get; set; }
    }
}
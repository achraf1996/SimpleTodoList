using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimpleTodoList.Domain.Models
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(255)]
        public string title { get; set; }
        public string description { get; set; }      
    }
}

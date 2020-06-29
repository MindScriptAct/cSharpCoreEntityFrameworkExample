using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListApp.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DeadLineDate { get; set; }

        [Required]
        [Range(1, 5)]
        public int Preority { get; set; } = 3;

        [Required]
        public TodoStatus Status { get; set; } = TodoStatus.Backlog;



    }
}

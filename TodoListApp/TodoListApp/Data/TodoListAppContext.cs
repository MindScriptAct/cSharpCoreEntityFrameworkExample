using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoListApp.Models;

namespace TodoListApp.Data
{
    public class TodoListAppContext : DbContext
    {
        public TodoListAppContext (DbContextOptions<TodoListAppContext> options)
            : base(options)
        {
        }

        public DbSet<TodoListApp.Models.TodoItem> TodoItem { get; set; }

        public DbSet<TodoListApp.Models.Category> Category { get; set; }
    }
}

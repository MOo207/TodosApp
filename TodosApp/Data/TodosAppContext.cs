#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodosApp.Models;

namespace TodosApp.Data
{
    public class TodosAppContext : DbContext
    {
        public TodosAppContext (DbContextOptions<TodosAppContext> options)
            : base(options)
        {
        }

        public DbSet<TodosApp.Models.TodoModel> TodoModel { get; set; }
    }
}

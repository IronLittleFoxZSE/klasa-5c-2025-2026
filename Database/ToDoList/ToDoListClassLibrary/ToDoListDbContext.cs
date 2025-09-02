using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListClassLibrary.Models;

namespace ToDoListClassLibrary
{
    internal class ToDoListDbContext : DbContext
    {
        public DbSet<ToDoTask> ToDoTasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=ToDoList;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.32-mariadb"));
            base.OnConfiguring(optionsBuilder);
        }

    }
}

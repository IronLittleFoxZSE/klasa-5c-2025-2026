using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListClassLibrary.Dtos;
using ToDoListClassLibrary.Models;

namespace ToDoListClassLibrary
{
    public class ToDoListRepository
    {
        private ToDoListDbContext dbContext;

        public ToDoListRepository()
        {
            dbContext = new ToDoListDbContext();
        }

        public void AddNewToDoTask(string name)
        {
            ToDoTask task = new ToDoTask()
            {
                Name = name,
                IsCompleted = false,
                IsDeleted = false,
            };
            dbContext.ToDoTasks.Add(task);
            dbContext.SaveChanges();
        }

        public IEnumerable<ToDoTaksDto> GetTasks(bool isDeleted)
        {
            return dbContext
                .ToDoTasks
                .Where(t => t.IsDeleted == isDeleted)
                .Select(t => new ToDoTaksDto() { Id = t.Id, Name = t.Name, IsCompleted = t.IsCompleted, IsDeleted = t.IsDeleted });
        }

        public void SetTaskCompleted(int id, bool isCompleted)
        {
            ToDoTask findTask = dbContext.ToDoTasks.Where(t => t.Id == id).FirstOrDefault();
            if (findTask != null)
            {
                findTask.IsCompleted = isCompleted;
                dbContext.SaveChanges();
            }
        }

        public void SetTaskDeleted(int id, bool isDeleted)
        {
            ToDoTask findTask = dbContext.ToDoTasks.Where(t => t.Id == id).FirstOrDefault();
            if (findTask != null)
            {
                findTask.IsDeleted = isDeleted;
                dbContext.SaveChanges();
            }
        }
    }
}

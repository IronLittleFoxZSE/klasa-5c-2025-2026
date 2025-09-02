using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ToDoListMauiApp.Model
{
    internal class ToDoTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsDeleted { get; set; }
        public ICommand SetCompletedCommand { get; set; }
        public ICommand SetDeletedCommand { get; set; }
    }
}

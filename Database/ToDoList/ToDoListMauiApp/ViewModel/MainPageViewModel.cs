using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoListClassLibrary;
using ToDoListMauiApp.Model;

namespace ToDoListMauiApp.ViewModel
{
    internal class MainPageViewModel : BindableObject
    {
        public ObservableCollection<ToDoTask> ToDoTasks { get; set; }
        public ObservableCollection<ToDoTask> ToDoDeletedTasks { get; set; }

        public string NewTaksName { get; set; }

        private ICommand addNewToDoTaskCommand;
        public ICommand AddNewToDoTaskCommand
        {
            get 
            {
                if (addNewToDoTaskCommand == null)
                    addNewToDoTaskCommand = new Command(() => 
                    {
                        toDoListRepository.AddNewToDoTask(NewTaksName);
                        LoadToDoTask(ToDoTasks, false);
                        NewTaksName = "";
                    });
                return addNewToDoTaskCommand; 
            }
        }

        private ICommand setCompletedCommand;
        public ICommand SetCompletedCommand
        {
            get
            {
                if (setCompletedCommand == null)
                    setCompletedCommand = new Command<ToDoTask>((toDoTask) =>
                    {
                        toDoListRepository.SetTaskCompleted(toDoTask.Id, true);
                        LoadToDoTask(ToDoTasks, false);
                    });
                return setCompletedCommand;
            }
        }

        private ICommand setDeletedCommand;
        public ICommand SetDeletedCommand
        {
            get
            {
                if (setDeletedCommand == null)
                    setDeletedCommand = new Command<ToDoTask>((toDoTask) =>
                    {
                        toDoListRepository.SetTaskDeleted(toDoTask.Id, true);
                        LoadToDoTask(ToDoTasks, false);
                        LoadToDoTask(ToDoDeletedTasks, true);
                    });
                return setDeletedCommand;
            }
        }

        private ToDoListRepository toDoListRepository;
        public MainPageViewModel()
        {
            toDoListRepository = new ToDoListRepository();
            ToDoTasks = new ObservableCollection<ToDoTask>();
            ToDoDeletedTasks = new ObservableCollection<ToDoTask>();
            NewTaksName = "";
        }

        private void LoadToDoTask(ObservableCollection<ToDoTask> collection, bool isDeleted)
        {
            collection.Clear();
            foreach (var toDoTask in toDoListRepository.GetTasks(isDeleted))
            {
                collection.Add(new ToDoTask() 
                {
                    Id = toDoTask.Id,
                    Name = toDoTask.Name,
                    IsCompleted = toDoTask.IsCompleted,
                    IsDeleted = toDoTask.IsDeleted,
                    SetCompletedCommand = SetCompletedCommand,
                    SetDeletedCommand = SetDeletedCommand
                });
            }
        }
    }
}

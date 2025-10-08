using System.Collections.ObjectModel;

namespace TaskManagerApp
{
    public class TaskManager
    {
        public ObservableCollection<TaskItem> Tasks { get; set; }

        public TaskManager()
        {
            Tasks = new ObservableCollection<TaskItem>();
        }

        public void AddTask(string description)
        {
            Tasks.Add(new TaskItem { Description = description, IsCompleted = false });
        }

        public void RemoveTask(TaskItem task)
        {
            Tasks.Remove(task);
        }
    }
}

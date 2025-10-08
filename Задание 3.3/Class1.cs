using System;

namespace Задание_3
{
    public class TaskItem
    {
        public string Description { get; set; }

        // Делегат для выполнения задачи
        public Action<string> TaskAction { get; set; }

        public TaskItem(string description, Action<string> taskAction)
        {
            Description = description;
            TaskAction = taskAction;
        }

        // Метод для выполнения задачи
        public void Execute()
        {
            TaskAction?.Invoke(Description);
        }
    }
}

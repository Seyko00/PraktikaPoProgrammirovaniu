using System.Windows;
using System.Windows.Controls;
using TaskManagerApp;

namespace Задание_3
{
    public partial class MainWindow : TaskItem
    {
        private readonly TaskManager _taskManager = new TaskManager();
        public MainWindow()
        {
            InitializeComponent();
            TasksListBox.ItemsSource = _taskManager.Tasks; // Устанавливаем источник данных для списка задач
        }

        public TaskManager TaskManager
        {
            get => default;
            set
            {
            }
        }

        private void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            string taskDescription = TaskInputTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(taskDescription))
            {
                _taskManager.AddTask(taskDescription);
                TaskInputTextBox.Clear(); // Очищаем текстовое поле после добавления задачи
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                TaskItem task = button.DataContext as TaskItem;
                if (task != null)
                {
                    _taskManager.RemoveTask(task);
                }
            }
        }

        private void TasksListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
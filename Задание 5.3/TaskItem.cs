using System.ComponentModel;

namespace TaskManagerApp
{
    public class TaskItem : INotifyPropertyChanged
    {
        private bool _isCompleted;

        public string Description { get; set; }

        public bool IsCompleted
        {
            get => _isCompleted;
            set
            {
                _isCompleted = value;
                OnPropertyChanged(nameof(IsCompleted));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

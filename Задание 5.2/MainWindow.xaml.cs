using Microsoft.Win32;
using System.Windows;
using TextEditorApp;

namespace Задание_2
{
    public partial class MainWindow : Window
    {
        private readonly FileManager fileManager = new FileManager();
        public MainWindow()
        {
            InitializeComponent();
        }

        public FileManager FileManager
        {
            get => default;
            set
            {
            }
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string fileContent = fileManager.OpenFile(openFileDialog.FileName);
                EditorTextBox.Text = fileContent;
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                fileManager.SaveFile(saveFileDialog.FileName, EditorTextBox.Text);
            }
        }
    }
}
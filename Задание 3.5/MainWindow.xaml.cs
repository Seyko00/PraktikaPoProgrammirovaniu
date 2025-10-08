using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media; 

namespace Задание_5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           
            SetPinkGradient();
        }

        private void SortButton_Click(object sender, RoutedEventArgs e)
        {
            string input = NumbersTextBox.Text;
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Введите хотя бы одно число.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            int[] numbers = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(n => int.TryParse(n.Trim(), out int num) ? num : 0)
                                 .ToArray();

            if (numbers.Length == 0)
            {
                MessageBox.Show("Введите корректные числа.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Action<int[]> sortingMethod = null;

            if (SortMethodSelector.SelectedItem is ComboBoxItem selectedMethod)
            {
                switch (selectedMethod.Content.ToString())
                {
                    case "Сортировка пузырьком":
                        sortingMethod = Sorter.BubbleSort;
                        break;
                    case "Быстрая сортировка":
                        sortingMethod = array => Sorter.QuickSort(array, 0, array.Length - 1);
                        break;
                }

                sortingMethod?.Invoke(numbers);
                ResultTextBox.Text = string.Join(", ", numbers);
            }
            else
            {
                MessageBox.Show("Выберите метод сортировки.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        
        private void SetPinkGradient()
        {
            LinearGradientBrush pinkGradient = new LinearGradientBrush();
            pinkGradient.StartPoint = new Point(0, 0);
            pinkGradient.EndPoint = new Point(1, 1);
            pinkGradient.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#FFFFC0CB"), 0)); 
            pinkGradient.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#FFFF69B4"), 1)); 

            this.Background = pinkGradient;
        }
    }
}

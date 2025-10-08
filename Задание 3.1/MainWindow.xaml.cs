using System;
using System.Windows;
using System.Windows.Media; 

namespace Задание_1
{
    public partial class MainWindow : Window
    {
        // Делегат для вызова метода вычисления площади
        private delegate double AreaCalculatorDelegate();

        public MainWindow()
        {
            InitializeComponent();
            ShapeSelector.SelectionChanged += ShapeSelector_SelectionChanged;

           
            this.Background = new LinearGradientBrush(
                Colors.Violet, 
                Colors.White,  
                new Point(0, 0), 
                new Point(1, 1)  
            );
        }

        private void ShapeSelector_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            InputFields.Children.Clear();
            if (ShapeSelector.SelectedItem is System.Windows.Controls.ComboBoxItem selectedShape)
            {
                switch (selectedShape.Content.ToString())
                {
                    case "Круг":
                        AddInputField("Радиус:");
                        break;
                    case "Прямоугольник":
                        AddInputField("Ширина:");
                        AddInputField("Высота:");
                        break;
                    case "Треугольник":
                        AddInputField("Основание:");
                        AddInputField("Высота:");
                        break;
                }
            }
        }

        private void AddInputField(string label)
        {
            var stackPanel = new System.Windows.Controls.StackPanel { Orientation = System.Windows.Controls.Orientation.Horizontal, Margin = new Thickness(0, 5, 0, 5) };
            stackPanel.Children.Add(new System.Windows.Controls.TextBlock { Text = label, Width = 100 });
            stackPanel.Children.Add(new System.Windows.Controls.TextBox { Width = 100 });
            InputFields.Children.Add(stackPanel);
        }

        private void CalculateAreaButton_Click(object sender, RoutedEventArgs e)
        {
            if (ShapeSelector.SelectedItem is System.Windows.Controls.ComboBoxItem selectedShape)
            {
                AreaCalculatorDelegate areaCalculator = null;
                Figure figure = null;

                try
                {
                    switch (selectedShape.Content.ToString())
                    {
                        case "Круг":
                            double radius = double.Parse(((System.Windows.Controls.TextBox)((System.Windows.Controls.StackPanel)InputFields.Children[0]).Children[1]).Text);
                            figure = new Circle(radius);
                            break;
                        case "Прямоугольник":
                            double width = double.Parse(((System.Windows.Controls.TextBox)((System.Windows.Controls.StackPanel)InputFields.Children[0]).Children[1]).Text);
                            double height = double.Parse(((System.Windows.Controls.TextBox)((System.Windows.Controls.StackPanel)InputFields.Children[1]).Children[1]).Text);
                            figure = new Rectangle(width, height);
                            break;
                        case "Треугольник":
                            double baseLength = double.Parse(((System.Windows.Controls.TextBox)((System.Windows.Controls.StackPanel)InputFields.Children[0]).Children[1]).Text);
                            double triangleHeight = double.Parse(((System.Windows.Controls.TextBox)((System.Windows.Controls.StackPanel)InputFields.Children[1]).Children[1]).Text);
                            figure = new Triangle(baseLength, triangleHeight);
                            break;
                    }

                    if (figure != null)
                    {
                        areaCalculator = figure.CalculateArea;
                        ResultTextBlock.Text = $"Площадь: {areaCalculator()}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка ввода данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}

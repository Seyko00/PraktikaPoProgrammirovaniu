using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Задание_4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Images (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage bitmap = new BitmapImage(new Uri(openFileDialog.FileName));
                ImageView.Source = bitmap; // Установка изображения в элемент Image
                ZoomSlider.Value = 1; // Сброс значения слайдера при открытии нового изображения
            }
        }

        private void ZoomSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (ImageView.Source != null)
            {
                ImageView.Width = ImageView.Source.Width * ZoomSlider.Value; // Изменение ширины
                ImageView.Height = ImageView.Source.Height * ZoomSlider.Value; // Изменение высоты
            }
        }
    }
}
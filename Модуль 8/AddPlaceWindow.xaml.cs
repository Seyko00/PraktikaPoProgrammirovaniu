using System;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using System.IO;

namespace InteractiveMap
{
    public abstract partial class AddPlaceWindow : MainWindow, WpfApp1.window, WpfApp1.window, WpfApp1.window
    {
        public string PlaceName { get; private set; }
        public string PlaceDescription { get; private set; }
        public string PlaceColor { get; private set; } = "Red";
        public string PlaceImagePath { get; private set; }

        public WpfApp1.window window
        {
            get => default;
            set
            {
            }
        }

        private double latitude;
        private double longitude;

        public AddPlaceWindow(double lat, double lng)
        {
            InitializeComponent();
            latitude = lat;
            longitude = lng;
            Title = $"Новая метка ({lat:F4}, {lng:F4})";
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void BrowseImage_Click(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameBox.Text))
            {
                MessageBox.Show("Введите название метки.");
                return;
            }

            PlaceName = NameBox.Text.Trim();
            PlaceDescription = DescBox.Text.Trim();
            PlaceColor = (ColorBox.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "Red";

            DialogResult = true;
            Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging; // Для работы с изображениями
using System.Windows.Shapes;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsPresentation;
using Newtonsoft.Json;

namespace InteractiveMap
{
    public partial class MainWindow : WpfApp1.window
    {
        private List<Place> places = new List<Place>();
        private readonly string placesFile = "places.json";

        public MainWindow()
        {
            InitializeComponent();
            InitMap();
            LoadPlacesFromFile(placesFile);
            PopulateList();
            AddMarkers();
        }

        public WpfApp1.window window
        {
            get => default;
            set
            {
            }
        }

        private void InitMap()
        {
            MainMap.MapProvider = GMapProviders.OpenStreetMap;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            MainMap.Position = new PointLatLng(55.7558, 37.6173);
            MainMap.MinZoom = 2;
            MainMap.MaxZoom = 18;
            MainMap.Zoom = 6;
            MainMap.ShowCenter = false;

            MainMap.MouseLeftButtonDown += MainMap_MouseLeftButtonDown;
        }

        private void MainMap_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var point = e.GetPosition(MainMap);
            var latlng = MainMap.FromLocalToLatLng((int)point.X, (int)point.Y);

            var dialog = new AddPlaceWindow(latlng.Lat, latlng.Lng);
            if (dialog.ShowDialog() == true)
            {
                var newPlace = new Place
                {
                    Name = dialog.PlaceName,
                    Description = dialog.PlaceDescription,
                    Latitude = latlng.Lat,
                    Longitude = latlng.Lng,
                    Color = dialog.PlaceColor,
                    ImagePath = dialog.PlaceImagePath // Сохраняем путь к изображению
                };
                places.Add(newPlace);
                SavePlacesToFile();
                PopulateList();
                AddMarkers();
            }
        }

        private void LoadPlacesFromFile(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    CreateSamplePlacesFile(path);
                }

                var json = File.ReadAllText(path);
                places = JsonConvert.DeserializeObject<List<Place>>(json) ?? new List<Place>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки places.json: " + ex.Message);
                places = new List<Place>();
            }
        }

        private void SavePlacesToFile()
        {
            try
            {
                var json = JsonConvert.SerializeObject(places, Formatting.Indented);
                File.WriteAllText(placesFile, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения меток: " + ex.Message);
            }
        }

        private void CreateSamplePlacesFile(string path)
        {
            var sample = new List<Place>
            {
                new Place { Name = "Красная площадь", Latitude = 55.7539, Longitude = 37.6208, Description = "Исторический центр Москвы.", Color = "Red" },
                new Place { Name = "Эрмитаж", Latitude = 59.9398, Longitude = 30.3146, Description = "Государственный Эрмитаж в Санкт-Петербурге.", Color = "Blue" }
            };
            File.WriteAllText(path, JsonConvert.SerializeObject(sample, Formatting.Indented));
        }

        private void PopulateList()
        {
            PlacesList.ItemsSource = null;
            PlacesList.ItemsSource = places;
        }

        private void AddMarkers()
        {
            MainMap.Markers.Clear();

            foreach (var p in places)
            {
                var position = new PointLatLng(p.Latitude, p.Longitude);

                var ellipse = new Ellipse
                {
                    Width = 18,
                    Height = 18,
                    Stroke = Brushes.Black,
                    StrokeThickness = 1,
                    Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(p.Color ?? "Red"),
                    Opacity = 0.9
                };

                var markerControl = new Grid();
                markerControl.Children.Add(ellipse);

                var marker = new GMapMarker(position)
                {
                    Shape = markerControl,
                    Offset = new Point(-9, -9),
                    Tag = p
                };

                markerControl.MouseLeftButtonUp += (s, e) =>
                {
                    e.Handled = true;
                    ShowPopupForPlace(p);
                };

                var toolTipContent = new StackPanel();
                toolTipContent.Children.Add(new TextBlock { Text = p.Name, FontWeight = FontWeights.Bold });

                if (!string.IsNullOrEmpty(p.ImagePath) && File.Exists(p.ImagePath))
                {
                    try
                    {
                        var image = new Image
                        {
                            Source = new BitmapImage(new Uri(p.ImagePath, UriKind.Absolute)),
                            Width = 100,
                            Height = 100,
                            Margin = new Thickness(0, 5, 0, 0)
                        };
                        toolTipContent.Children.Add(image);
                    }
                    catch (Exception ex)
                    {
                        toolTipContent.Children.Add(new TextBlock { Text = "Ошибка загрузки изображения: " + ex.Message, Foreground = Brushes.Red });
                    }
                }

                markerControl.ToolTip = new ToolTip { Content = toolTipContent };

                MainMap.Markers.Add(marker);
            }
        }

        private void DeleteSelectedPlace_Click(object sender, RoutedEventArgs e)
        {
            var selected = PlacesList.SelectedItem as Place;
            if (selected == null)
            {
                MessageBox.Show("Выберите метку для удаления.");
                return;
            }

            var result = MessageBox.Show(
                string.Format("Удалить метку «{0}»?", selected.Name),
                "Подтверждение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                places.Remove(selected);
                try
                {
                    var json = JsonConvert.SerializeObject(places, Formatting.Indented);
                    File.WriteAllText(placesFile, json);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении: " + ex.Message);
                }

                PopulateList();
                AddMarkers();
            }
        }

        private void ShowPopupForPlace(Place p)
        {
            PopupTitle.Text = p.Name;
            PopupDescription.Text = p.Description;
            InfoPopup.IsOpen = true;

            MainMap.Position = new PointLatLng(p.Latitude, p.Longitude);
            MainMap.Zoom = Math.Max(MainMap.Zoom, 12);
        }

        private void ClosePopup_Click(object sender, RoutedEventArgs e)
        {
            InfoPopup.IsOpen = false;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var q = SearchBox.Text?.Trim().ToLower();
            if (string.IsNullOrEmpty(q))
            {
                PlacesList.ItemsSource = places;
                return;
            }

            var filtered = places.Where(x =>
                (x.Name ?? "").ToLower().Contains(q) ||
                (x.Description ?? "").ToLower().Contains(q)).ToList();

            PlacesList.ItemsSource = filtered;

            if (filtered.Count == 1)
            {
                var p = filtered.First();
                MainMap.Position = new PointLatLng(p.Latitude, p.Longitude);
                MainMap.Zoom = 12;
            }
        }

        private void PlacesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PlacesList.SelectedItem is Place p)
            {
                ShowPopupForPlace(p);
            }
        }

        private void LoadMarkersButton_Click(object sender, RoutedEventArgs e)
        {
            LoadPlacesFromFile(placesFile);
            PopulateList();
            AddMarkers();
            MessageBox.Show($"Загружено {places.Count} мест.");
        }
    }
}
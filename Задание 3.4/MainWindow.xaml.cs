using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media; 

namespace Задание_4
{
    public partial class MainWindow : Window
    {
        private List<DataItem> _dataItems;
        private List<DataItem> _filteredDataItems;

        public MainWindow()
        {
            InitializeComponent();

            
            this.Background = new LinearGradientBrush(
                new GradientStopCollection
                {
                    new GradientStop((Color)ColorConverter.ConvertFromString("#FFB6C1"), 0.0),
                    new GradientStop((Color)ColorConverter.ConvertFromString("#FF69B4"), 1.0)  
                },
                new Point(0, 0),
                new Point(1, 1)
            );

            InitializeData();
        }

        private void InitializeData()
        {
            // Инициализация данных
            _dataItems = new List<DataItem>
            {
                new DataItem("Событие A", new DateTime(2025, 09, 1)),
                new DataItem("Событие B", new DateTime(2025, 09, 10)),
                new DataItem("Событие C", new DateTime(2025, 10, 31)),
                new DataItem("Событие D", new DateTime(2025, 11, 15)),
                new DataItem("Конференция", new DateTime(2025, 12, 24))
            };

            _filteredDataItems = new List<DataItem>(_dataItems);
            UpdateDataList();
        }

        private void UpdateDataList()
        {
            DataListBox.Items.Clear();
            foreach (var item in _dataItems)
            {
                DataListBox.Items.Add(item);
            }

            FilteredDataListBox.Items.Clear();
            foreach (var item in _filteredDataItems)
            {
                FilteredDataListBox.Items.Add(item);
            }
        }

        private void ApplyFilterButton_Click(object sender, RoutedEventArgs e)
        {
            if (FilterSelector.SelectedItem is ComboBoxItem selectedFilter && !string.IsNullOrWhiteSpace(FilterValueTextBox.Text))
            {
                Func<DataItem, bool> filter = null;

                switch (selectedFilter.Content.ToString())
                {
                    case "Фильтр по дате (после)":
                        if (DateTime.TryParse(FilterValueTextBox.Text, out DateTime filterDate))
                        {
                            filter = item => item.Date > filterDate;
                        }
                        else
                        {
                            MessageBox.Show("Введите корректную дату.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                            return;
                        }
                        break;

                    case "Фильтр по ключевому слову":
                        string keyword = FilterValueTextBox.Text.ToLower();
                        filter = item => item.Title.ToLower().Contains(keyword);
                        break;
                }

                if (filter != null)
                {
                    _filteredDataItems = _dataItems.Where(filter).ToList();
                    UpdateDataList();
                }
            }
            else
            {
                MessageBox.Show("Выберите фильтр и введите значение.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}

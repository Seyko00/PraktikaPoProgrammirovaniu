using System;
namespace Задание_5
{
    class TemperatureSensor
    {
        // Делегат для события изменения температуры
        public delegate void TemperatureChangedHandler(double newTemperature);
        // Событие на основе делегата
        public event TemperatureChangedHandler TemperatureChanged;
        private double _temperature;
        // Свойство для установки и получения температуры
        public double Temperature
        {
            get { return _temperature; }
            set
            {
                if (_temperature != value)
                {
                    _temperature = value;
                    OnTemperatureChanged(_temperature); // Генерация события при изменении
                }
            }
        }
        // Метод, вызываемый при изменении температуры, для генерации события
        protected virtual void OnTemperatureChanged(double newTemperature)
        {
            if (TemperatureChanged != null)
            {
                TemperatureChanged(newTemperature); // Если есть подписчики, вызываем событие
            }
        }
    }
    class Thermostat
    {
        private double _desiredTemperature;
        // Конструктор для задания желаемой температуры
        public Thermostat(double desiredTemperature)
        {
            _desiredTemperature = desiredTemperature;
        }
        // Метод, обрабатывающий событие изменения температуры
        public void OnTemperatureChanged(double newTemperature)
        {
            if (newTemperature < _desiredTemperature)
            {
                Console.WriteLine($"Температура {newTemperature}°C слишком низкая. Включение отопления...");
            }
            else if (newTemperature > _desiredTemperature)
            {
                Console.WriteLine($"Температура {newTemperature}°C слишком высокая. Выключение отопления...");
            }
            else
            {
                Console.WriteLine($"Температура {newTemperature}°C оптимальная. Оставляем текущее состояние отопления.");
            }
        }
    }
}

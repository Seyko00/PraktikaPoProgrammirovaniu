using System;
namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта датчика температуры
            TemperatureSensor sensor = new TemperatureSensor();
            // Ввод желаемой температуры для термостата
            Console.WriteLine("Введите желаемую температуру для термостата:");
            double desiredTemperature = double.Parse(Console.ReadLine());
            // Создание объекта термостата
            Thermostat thermostat = new Thermostat(desiredTemperature);
            // Подписка термостата на событие изменения температуры
            sensor.TemperatureChanged += thermostat.OnTemperatureChanged;

            // Ввод данных для изменения температуры
            Console.WriteLine("Введите текущую температуру:");
            double currentTemperature = double.Parse(Console.ReadLine());
            sensor.Temperature = currentTemperature;
            // Ввод следующего значения температуры
            Console.WriteLine("Введите новую температуру:");
            double newTemperature = double.Parse(Console.ReadLine());
            sensor.Temperature = newTemperature;
        }
    }
}

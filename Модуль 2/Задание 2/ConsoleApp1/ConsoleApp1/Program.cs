using System;
namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод данных о круге
            Console.WriteLine("Введите данные о круге: ");
            Console.Write("Радиус: ");
            double radius = double.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);
            // Ввод данных о прямоугольнике
            Console.WriteLine("Введите данные о прямоугольнике: ");
            Console.Write("Ширина: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Высота: ");
            double height = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width, height);
            // Вывод данных о фигурах
            Console.WriteLine("\nИнформация о круге:");
            circle.Print();
            Console.WriteLine("\nИнформация о прямоугольнике:");
            rectangle.Print();
        }
    }
}

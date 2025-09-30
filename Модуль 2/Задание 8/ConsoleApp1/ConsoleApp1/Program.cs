using System;
namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта круга
            Console.Write("Введите радиус круга: ");
            double radius = double.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);
            // Создание объекта прямоугольника
            Console.Write("Введите ширину прямоугольника: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту прямоугольника: ");
            double height = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width, height);
            // Создание объекта треугольника
            Console.Write("Введите основание треугольника: ");
            double baseLength = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту треугольника: ");
            double triangleHeight = double.Parse(Console.ReadLine());
            Triangle triangle = new Triangle(baseLength, triangleHeight);
            // Вывод информации о площадях фигур
            Console.WriteLine($"\nПлощадь круга: {circle.CalculateArea():F2}");
            Console.WriteLine($"Площадь прямоугольника: {rectangle.CalculateArea():F2}");
            Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea():F2}");
        }
    }
}

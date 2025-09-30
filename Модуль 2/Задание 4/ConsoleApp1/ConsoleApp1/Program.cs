using System;
namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание массива объектов, реализующих интерфейс IDrawable
            IDrawable[] shapes = new IDrawable[3];
            // Ввод данных для круга
            Console.Write("Введите радиус круга:");
            double radius = double.Parse(Console.ReadLine());
            shapes[0] = new Circle(radius);
            // Ввод данных для прямоугольника
            Console.Write("Введите ширину прямоугольника:");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту прямоугольника:");
            double height = double.Parse(Console.ReadLine());
            shapes[1] = new Rectangle(width, height);
            // Ввод данных для треугольника
            Console.Write("Введите длину первой стороны треугольника:");
            double sideA = double.Parse(Console.ReadLine());
            Console.Write("Введите длину второй стороны треугольника:");
            double sideB = double.Parse(Console.ReadLine());
            Console.Write("Введите длину третьей стороны треугольника:");
            double sideC = double.Parse(Console.ReadLine());
            shapes[2] = new Triangle(sideA, sideB, sideC);
            // Вызов метода Draw для каждого объекта
            Console.WriteLine("\nРисуем фигуры:");
            foreach (IDrawable shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}

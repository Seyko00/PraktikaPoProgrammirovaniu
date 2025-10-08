using System;

namespace Задание_1
{
    // Базовый класс "Фигура"
    public abstract class Figure
    {
        // Метод для вычисления площади (будет переопределён в наследниках)
        public abstract double CalculateArea();
    }

    // Производный класс "Круг"
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Производный класс "Прямоугольник"
    public class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    // Производный класс "Треугольник"
    public class Triangle : Figure
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double baseLength, double height)
        {
            Base = baseLength;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }
}

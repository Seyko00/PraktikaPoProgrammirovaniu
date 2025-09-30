using System;
// Абстрактный класс "Геометрическая фигура"
public abstract class Shape
{
    // Абстрактный метод для вычисления площади
    public abstract double CalculateArea();
}
// Класс "Круг"
public class Circle : Shape
{
    public double Radius { get; set; }

    // Конструктор для инициализации радиуса круга
    public Circle(double radius)
    {
        Radius = radius;
    }
    // Реализация метода для вычисления площади круга
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
// Класс "Прямоугольник"
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    // Конструктор для инициализации ширины и высоты прямоугольника
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Реализация метода для вычисления площади прямоугольника
    public override double CalculateArea()
    {
        return Width * Height;
    }
}
// Класс "Треугольник"
public class Triangle : Shape
{
    public double BaseLength { get; set; }
    public double Height { get; set; }
    // Конструктор для инициализации основания и высоты треугольника
    public Triangle(double baseLength, double height)
    {
        BaseLength = baseLength;
        Height = height;
    }
    // Реализация метода для вычисления площади треугольника
    public override double CalculateArea()
    {
        return 0.5 * BaseLength * Height;
    }
}

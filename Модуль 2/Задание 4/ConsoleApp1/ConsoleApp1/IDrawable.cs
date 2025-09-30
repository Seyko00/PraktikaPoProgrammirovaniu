using System;
namespace Задание_4
{
    // Определение интерфейса IDrawable
    interface IDrawable
    {
        void Draw();
    }
    // Класс Circle, реализующий интерфейс IDrawable
    class Circle : IDrawable
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        // Реализация метода Draw для круга
        public void Draw()
        {
            Console.WriteLine($"Рисуем круг с радиусом: {Radius}");
        }
    }
    // Класс Rectangle, реализующий интерфейс IDrawable
    class Rectangle : IDrawable
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        // Реализация метода Draw для прямоугольника
        public void Draw()
        {
            Console.WriteLine($"Рисуем прямоугольник с шириной: {Width} и высотой: {Height}");
        }
    }
    // Класс Triangle, реализующий интерфейс IDrawable
    class Triangle : IDrawable
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        // Реализация метода Draw для треугольника
        public void Draw()
        {
          Console.WriteLine($"Рисуем треугольник со сторонами: {SideA}, {SideB}, {SideC}");
        }
    }
}

using System;
namespace Задание_2
{
    class Shape
    {
        public virtual double Area { get; set; }
        public virtual double Perimeter { get; set; }
        public virtual void Print()
        {
            Console.WriteLine($"Площадь: {Area:F2}, Периметр: {Perimeter:F2}");
        }
    }
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
            Area = Math.PI * Radius * Radius;
            Perimeter = 2 * Math.PI * Radius;
        }
        public override void Print()
        {
            Console.WriteLine($"Круг с радиусом: {Radius}");
            base.Print();
        }
    }
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
            Area = Width * Height;
            Perimeter = 2 * (Width + Height);
        }
        public override void Print()
        {
            Console.WriteLine($"Прямоугольник с шириной: {Width} и высотой: {Height}");
            base.Print();
        }
    }
}

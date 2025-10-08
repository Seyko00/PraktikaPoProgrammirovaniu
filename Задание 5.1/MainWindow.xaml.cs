using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Задание_1
{
    public partial class MainWindow : Window
{
    private enum ShapeType { None, Line, Circle, Square }
    private ShapeType currentShape = ShapeType.None;
    private Point startPoint;
    public MainWindow()
        {
            InitializeComponent();
            LineButton.Click += LineButton_Click;
            CircleButton.Click += CircleButton_Click;
            SquareButton.Click += SquareButton_Click;
            DrawingCanvas.MouseDown += DrawingCanvas_MouseDown;
            DrawingCanvas.MouseUp += DrawingCanvas_MouseUp;
        }

        private void LineButton_Click(object sender, RoutedEventArgs e)
        {
            currentShape = ShapeType.Line;
        }

        private void CircleButton_Click(object sender, RoutedEventArgs e)
        {
            currentShape = ShapeType.Circle;
        }

        private void SquareButton_Click(object sender, RoutedEventArgs e)
        {
            currentShape = ShapeType.Square;
        }

        private void DrawingCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(DrawingCanvas);
        }

        private void DrawingCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Point endPoint = e.GetPosition(DrawingCanvas);

            switch (currentShape)
            {
                case ShapeType.Line:
                    DrawLine(startPoint, endPoint);
                    break;
                case ShapeType.Circle:
                    DrawCircle(startPoint, endPoint);
                    break;
                case ShapeType.Square:
                    DrawSquare(startPoint, endPoint);
                    break;
            }
        }

        private void DrawLine(Point start, Point end)
        {
            Line line = new Line
            {
                X1 = start.X,
                Y1 = start.Y,
                X2 = end.X,
                Y2 = end.Y,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            DrawingCanvas.Children.Add(line);
        }

        private void DrawCircle(Point start, Point end)
        {
            double radius = Math.Abs(end.X - start.X);
            Ellipse circle = new Ellipse
            {
                Width = radius * 2,
                Height = radius * 2,
                Stroke = Brushes.Blue,
                StrokeThickness = 2
            };
            Canvas.SetLeft(circle, start.X - radius);
            Canvas.SetTop(circle, start.Y - radius);
            DrawingCanvas.Children.Add(circle);
        }

        private void DrawSquare(Point start, Point end)
        {
            double side = Math.Abs(end.X - start.X);
            Rectangle square = new Rectangle
            {
                Width = side,
                Height = side,
                Stroke = Brushes.Green,
                StrokeThickness = 2
            };
            Canvas.SetLeft(square, start.X);
            Canvas.SetTop(square, start.Y);
            DrawingCanvas.Children.Add(square);
        }
    }
}
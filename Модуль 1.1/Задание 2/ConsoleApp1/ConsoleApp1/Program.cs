using System;
class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя радиус
        Console.Write("Введите радиус круга: ");
        double R = Convert.ToDouble(Console.ReadLine());

        // Проверяем, что радиус не отрицательный
        if (R < 0)
        {
            Console.WriteLine("Ошибка: радиус не может быть отрицательным. Пожалуйста, введите положительное значение.");
        }
        else
        {
            // Вычисляем площадь круга
            double S = Math.PI * Math.Pow(R, 2);

            // Выводим результат
            Console.WriteLine($"Площадь круга с радиусом {R} равна {S:F2}");
        }
        Console.ReadKey();
    }
}

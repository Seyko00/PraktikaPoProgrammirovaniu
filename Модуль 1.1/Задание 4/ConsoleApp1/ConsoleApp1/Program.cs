using System;
class Program
{
    static void Main()
    {
        // Создаем генератор случайных чисел
        Random random = new Random();
        // Инициализируем массив из 20 элементов
        int[] numbers = new int[20];
        // Заполняем массив случайными числами от 0 до 100
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(0, 101);
        }
        // Находим максимальное и минимальное значения
        int max = numbers[0];
        int min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        // Выводим массив
        Console.WriteLine("Массив случайных чисел:");
        Console.WriteLine(string.Join(", ", numbers));
        // Выводим максимальное и минимальное значение
        Console.WriteLine($"\nМаксимальное значение: {max}");
        Console.WriteLine($"Минимальное значение: {min}");
        Console.ReadKey();
    }
}

using System;
class Program
{
    static void Main()
    {
        // Ввод размера массива
        Console.Write("Введите размер массива N: ");
        int N = int.Parse(Console.ReadLine());
        // Ввод элементов массива
        double[] array = new double[N];
        Console.WriteLine("Введите элементы массива: ");
        for (int i = 0; i < N; i++)
        {
            array[i] = double.Parse(Console.ReadLine());
        }
        // Поиск максимального по модулю элемента
        double maxAbs = Math.Abs(array[0]);
        for (int i = 1; i < N; i++)
        {
            if (Math.Abs(array[i]) > maxAbs)
            {
                maxAbs = Math.Abs(array[i]);
            }
        }
        // Нормировка элементов массива
        for (int i = 0; i < N; i++)
        {
            array[i] /= maxAbs;
        }
        // Вывод нормированных элементов
        Console.WriteLine("Нормированные элементы массива:");
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}

using System;
class Program
{
    static void Main()
    {
        // Ввод данных: K, A и B
        Console.Write("Введите количество элементов массива K: ");
        int K = int.Parse(Console.ReadLine());
        Console.Write("Введите значение A (нижняя граница диапазона): ");
        int A = int.Parse(Console.ReadLine());
        Console.Write("Введите значение B (верхняя граница диапазона): ");
        int B = int.Parse(Console.ReadLine());
        // Инициализация массива и генерация случайных чисел
        int[] array = new int[K];
        Random random = new Random();

        Console.WriteLine("\nСгенерированный массив:");
        for (int i = 0; i < K; i++)
        {
            array[i] = random.Next(A, B);
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        // Поиск индексов минимального и максимального элементов
        int minIndex = 0, maxIndex = 0;
        for (int i = 1; i < K; i++)
        {
            if (array[i] < array[minIndex])
                minIndex = i;

            if (array[i] > array[maxIndex])
                maxIndex = i;
        }
        // Вывод индексов минимального и максимального элементов
        Console.WriteLine($"\nМинимальный элемент: {array[minIndex]}, индекс: {minIndex}");
        Console.WriteLine($"Максимальный элемент: {array[maxIndex]}, индекс: {maxIndex}");
        // Вывод элементов, расположенных между минимальным и максимальным
        Console.WriteLine("\nЭлементы между минимальным и максимальным (включая их):");

        if (minIndex < maxIndex)
        {
            for (int i = minIndex; i <= maxIndex; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        else
        {
            for (int i = maxIndex; i <= minIndex; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        Console.WriteLine();
    }
}

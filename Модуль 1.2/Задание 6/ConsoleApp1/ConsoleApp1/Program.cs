using System;
using System.Linq; // Для использования методов сортировки
class Program
{
    static void Main()
    {
        // Инициализация массива из 10 элементов и генерация случайных значений
        double[] array = new double[10];
        Random random = new Random();
        Console.WriteLine("Сгенерированный массив:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.NextDouble() * 20 - 10; // Случайное число в диапазоне [-10, 10)
            Console.Write($"{array[i]:F2} "); // Форматируем вывод с двумя знаками после запятой
        }
        Console.WriteLine();
        // Формирование массива индексов, сортирующих элементы по возрастанию
        int[] indices = array
            .Select((value, index) => new { Value = value, Index = index }) // Связать значение и индекс
            .OrderBy(x => x.Value) // Сортировать по значению
            .Select(x => x.Index) // Получить только индексы
            .ToArray();
        // Вывод массива индексов
        Console.WriteLine("\nМассив индексов для сортировки по возрастанию:");
        foreach (int index in indices)
        {
            Console.Write(index + " ");
        }
        Console.WriteLine();
    }
}


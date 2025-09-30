using System;
class Program
{
    static void Main()
    {
        // Инициализация массива из 10 элементов
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // Вывод оригинального массива
        Console.WriteLine("Оригинальный массив:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
        // Ввод целого числа от пользователя
        Console.Write("Введите целое число для замены максимального элемента: ");
        int userInput = int.Parse(Console.ReadLine());
        // Поиск индекса максимального элемента
        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }
        // Замена максимального элемента на введенное число
        array[maxIndex] = userInput;
        // Вывод измененного массива
        Console.WriteLine("Измененный массив:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}

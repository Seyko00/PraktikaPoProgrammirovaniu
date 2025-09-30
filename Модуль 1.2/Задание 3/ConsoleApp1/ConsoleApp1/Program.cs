using System;
class Program
{
    static void Main()
    {
        // Ввод значения K
        Console.Write("Введите количество простых чисел K: ");
        int K = int.Parse(Console.ReadLine());
        // Переменные для поиска простых чисел
        int count = 0; // количество найденных простых чисел
        int number = 2; // текущее число для проверки на простоту
        // Поиск простых чисел
        while (count < K)
        {
            if (IsPrime(number))
            {
                Console.Write(number + "\t"); // вывод простого числа
                count++;

                // Размещаем числа по 10 на строке
                if (count % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
            number++;
        }
    }
    // Метод для проверки числа на простоту
    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}


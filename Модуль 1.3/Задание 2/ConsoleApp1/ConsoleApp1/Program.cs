using System;
using static System.Console;
internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Ввод числа, которое будет являться суммой элементов массива
            WriteLine("Введите число, которое будет являться суммой элементов массива:");
            int targetSum = Convert.ToInt32(ReadLine());

            // Проверка корректности ввода числа
            if (targetSum <= 0)
            {
                WriteLine("Число должно быть больше 0");
                WriteLine("Хотите выполнить еще одно преобразование? (Y для продолжения, любой другой символ для выхода):");
                char Zerochoice = ReadKey().KeyChar;
                WriteLine(); // Переход на новую строку

                if (Zerochoice != 'Y' && Zerochoice != 'y')
                    break; // Прерываем цикл и завершаем программу, если пользователь не ввел 'Y'

                continue; // Переход к следующей итерации цикла
            }
            // Массив для хранения элементов
            var elements = new System.Collections.Generic.List<int>();
            Random rand = new Random();
            int currentSum = 0;
            // Заполнение массива максимальными значениями
            while (currentSum < targetSum)
            {
                int valueToAdd = Math.Min(9, targetSum - currentSum); // Определяем максимальное значение для добавления
                elements.Add(valueToAdd);
                currentSum += valueToAdd;
            }
            // Преобразуем список в массив
            int[] resultArray = elements.ToArray();
            // Вывод результата
            WriteLine("Сгенерированный массив: " + string.Join(", ", resultArray)); // Вывод элементов массива
            WriteLine("Сумма элементов: " + currentSum);

            WriteLine("Хотите выполнить еще одно преобразование? (Y для продолжения, любой другой символ для выхода):");
            char choice = ReadKey().KeyChar;
            WriteLine(); // Переход на новую строку
            if (choice != 'Y' && choice != 'y')
                break; // Прерываем цикл и завершаем программу, если пользователь не ввел 'Y'
        }

        WriteLine("Программа завершена.");
    }
}

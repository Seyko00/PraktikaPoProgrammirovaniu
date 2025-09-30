using System;
using static System.Console;
class Program
{
    static void Main()
    {
        // Ввод числителя и знаменателя
        Write("Введите числитель (неотрицательное число): ");
        int numerator = int.Parse(ReadLine());
        Write("Введите знаменатель (положительное число): ");
        int denominator = int.Parse(ReadLine());
        // Проверка на корректность ввода
        if (numerator < 0 || denominator <= 0)
        {
            WriteLine("Ошибка: числитель должен быть неотрицательным, а знаменатель положительным числом.");
            return;
        }
        // Вычисление НОД числителя и знаменателя
        int gcd = GCD(numerator, denominator);
        // Сокращение дроби
        int reducedNumerator = numerator / gcd;
        int reducedDenominator = denominator / gcd;
        // Вывод сокращенной дроби
        WriteLine($"Сокращенная дробь: {reducedNumerator}/{reducedDenominator}");
    }
    // Статический метод для вычисления НОД двух чисел
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}

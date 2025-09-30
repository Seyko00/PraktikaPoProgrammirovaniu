using System;
class Program
{
    static void Main()
    {
        //Запрашиваем у пользователя имя
        Console.Write("Введите имя: ");
        string N = Console.ReadLine();
        //Запрашиваем у пользователя фамилию
        Console.Write("Введите фамилия: ");
        string F = Console.ReadLine();
        Console.WriteLine($"{F}, {N}");
        Console.ReadKey();
    }
}
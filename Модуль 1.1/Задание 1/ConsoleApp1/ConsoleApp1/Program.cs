using System;
class Program
{
    static void Main(string[] args)
    {
        int a;
        Console.Write("введите число: ");
        a = Console.Read();
        if (a % 2 == 1)
        {
            Console.WriteLine("число нечетное");
        }
        else
        {
            Console.WriteLine("Число четное");
        }
        Console.ReadKey();
    }
}

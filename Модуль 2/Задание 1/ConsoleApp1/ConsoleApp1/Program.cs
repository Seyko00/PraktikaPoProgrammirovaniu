using System;
namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод данных о первом человеке
            Console.WriteLine("Введите данные о первом человеке: ");
            Console.Write("Имя: ");
            string Name1 = Console.ReadLine();
            Console.Write("Возраст: ");
            int Age1 = int.Parse(Console.ReadLine());
            Console.Write("Адрес: ");
            string Address1 = Console.ReadLine();
            // Создание объекта класса Person с введёнными данными
            Person person1 = new Person(Name1, Age1, Address1);
            // Ввод данных о втором человеке
            Console.WriteLine("Введите данные о втором человеке: ");
            Console.Write("Имя: ");
            string Name2 = Console.ReadLine();
            Console.Write("Возраст: ");
            int Age2 = int.Parse(Console.ReadLine());
            Console.Write("Адрес: ");
            string Address2 = Console.ReadLine();
            // Создание второго объекта класса Person с введёнными данными
            Person person2 = new Person(Name2, Age2, Address2);
            // Вывод информации о первом человеке
            Console.WriteLine("\nИнформация о первом человеке:");
            person1.Print();
            // Вывод информации о втором человеке
            Console.WriteLine("\nИнформация о втором человеке:");
            person2.Print();
        }
    }
}

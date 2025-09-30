using System;
using System.Runtime.ConstrainedExecution;
namespace Задание_1
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Введите информацию о первой машине: ");
            Console.Write("Марка: ");
            string brand1 = Console.ReadLine();
            Console.Write("Модель: ");
            string model1 = Console.ReadLine();
            Console.Write("Год выпуска: ");
            int year_of_release1 = int.Parse(Console.ReadLine());
            Console.Write("Цена: ");
            int price1 = int.Parse(Console.ReadLine());
            Car car1 = new Car(brand1, model1, year_of_release1, price1);
            Console.WriteLine("Введите информацию о второй машине: ");
            Console.Write("Марка: ");
            string brand2 = Console.ReadLine();
            Console.Write("Модель: ");
            string model2 = Console.ReadLine();
            Console.Write("Год выпуска: ");
            int year_of_release2 = int.Parse(Console.ReadLine());
            Console.Write("Цена: ");
            int price2 = int.Parse(Console.ReadLine());
            Car car2 = new Car(brand2, model2, year_of_release2, price2);
            // Выводим информацию о машинах
            Console.WriteLine("\nИнформация о первой машине:");
            car1.Print();
            Console.WriteLine("\nИнформация о второй машине:");
            car2.Print();
            // Рассчет стоимости с учетом скидки и НДС
            Console.WriteLine("\nВведите процент скидки: ");
            double discount = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите процент налога на добавленную стоимость (НДС): ");
            double tax = double.Parse(Console.ReadLine());
            // Рассчет для первой машины
            double priceWithDiscount1 = car1.GetPriceWithDiscount(discount);
            double priceWithTax1 = car1.GetPriceWithTax(tax);
            Console.WriteLine($"\nЦена первой машины с учетом скидки: {priceWithDiscount1}");
            Console.WriteLine($"Цена первой машины с учетом НДС: {priceWithTax1}");
            // Рассчет для второй машины
            double priceWithDiscount2 = car2.GetPriceWithDiscount(discount);
            double priceWithTax2 = car2.GetPriceWithTax(tax);
            Console.WriteLine($"\nЦена второй машины с учетом скидки: {priceWithDiscount2}");
            Console.WriteLine($"Цена второй машины с учетом НДС: {priceWithTax2}");
        }
    }
}

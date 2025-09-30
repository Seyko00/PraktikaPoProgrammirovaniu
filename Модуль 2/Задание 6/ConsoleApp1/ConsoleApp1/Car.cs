using System;
namespace Задание_1
{
    class Car
    {
        public string brand { get; set; }
        public string model { get; set; }
        public int year_of_release { get; set; }
        public int price { get; set; }

        public Car(string brand, string model, int year_of_release, int price)
        {
            this.brand = brand;
            this.model = model;
            this.year_of_release = year_of_release;
            this.price = price;
        }

        // Метод для вывода информации о машине
        public void Print()
        {
            Console.WriteLine($"Марка: {brand}, Модель: {model}, Год выпуска: {year_of_release}, Цена: {price}");
        }

        // Метод для расчета стоимости с учетом скидки
        public double GetPriceWithDiscount(double discountPercentage)
        {
            double discountAmount = price * (discountPercentage / 100);
            return price - discountAmount;
        }

        // Метод для расчета стоимости с учетом НДС
        public double GetPriceWithTax(double taxPercentage)
        {
            double taxAmount = price * (taxPercentage / 100);
            return price + taxAmount;
        }
    }
}

using System;
namespace Задание_1
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        // Конструктор класса Person
        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
        // Метод для вывода информации о человеке
        public void Print()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Адрес: {Address}");
        }
    }
}

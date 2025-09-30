using System;
namespace Задание_3
{
    class Author
    {
        // Свойства для имени и года рождения автора
        public string Name { get; set; }
        public int BirthYear { get; set; }
        // Конструктор для инициализации имени и года рождения автора
        public Author(string name, int birthYear)
        {
            Name = name;
            BirthYear = birthYear;
        }
        // Метод для вывода информации об авторе
        public void Print()
        {
            Console.WriteLine($"Автор: {Name}, Год рождения: {BirthYear}");
        }
    }
    class Book
    {
        // Свойства для названия книги, года выпуска и автора
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public Author Author { get; set; } // Композиция: объект класса Author включен в объект Book
        // Конструктор для инициализации книги с названием, годом выпуска и объектом автора
        public Book(string title, int releaseYear, Author author)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Author = author;
        }
        // Метод для вывода информации о книге
        public void Print()
        {
            Console.WriteLine($"Книга: {Title}, Год выпуска: {ReleaseYear}");
            Author.Print(); // Вывод информации об авторе через объект Author
        }
    }
}

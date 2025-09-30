using System;
namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод данных об авторе
            Console.WriteLine("Введите информацию о первом авторе:");
            Console.Write("Имя автора: ");
            string authorName1 = Console.ReadLine();
            Console.Write("Год рождения автора: ");
            int authorBirthYear1 = int.Parse(Console.ReadLine());
            Author author1 = new Author(authorName1, authorBirthYear1); // Создание объекта автора

            Console.WriteLine("Введите информацию о книге:");
            Console.Write("Название книги: ");
            string bookTitle1 = Console.ReadLine();
            Console.Write("Год выпуска книги: ");
            int bookReleaseYear1 = int.Parse(Console.ReadLine());
            // Создание объекта книги с введённым автором
            Book book1 = new Book(bookTitle1, bookReleaseYear1, author1);
            // Ввод данных для второго автора и книги
            Console.WriteLine("\nВведите информацию о втором авторе:");
            Console.Write("Имя автора: ");
            string authorName2 = Console.ReadLine();
            Console.Write("Год рождения автора: ");
            int authorBirthYear2 = int.Parse(Console.ReadLine());
            Author author2 = new Author(authorName2, authorBirthYear2); // Создание второго объекта автора
            Console.WriteLine("Введите информацию о второй книге:");
            Console.Write("Название книги: ");
            string bookTitle2 = Console.ReadLine();
            Console.Write("Год выпуска книги: ");
            int bookReleaseYear2 = int.Parse(Console.ReadLine());
            // Создание второго объекта книги
            Book book2 = new Book(bookTitle2, bookReleaseYear2, author2);
            // Вывод информации о книгах и авторах
            Console.WriteLine("\nИнформация о первой книге:");
            book1.Print();
            Console.WriteLine("\nИнформация о второй книге:");
            book2.Print();
        }
    }
}

using System;
namespace Задание_2
{
    // Program.cs
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем массив из 10 студентов
            Student[] students = new Student[10];
            // Ввод данных для каждого студента
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Введите данные для студента №{i + 1}:");
                Console.Write("Фамилия: ");
                string lastName = Console.ReadLine();
                Console.Write("Инициалы: ");
                string initials = Console.ReadLine();
                Console.Write("Номер группы: ");
                int groupNumber = int.Parse(Console.ReadLine());
                int[] grades = new int[5];
                Console.WriteLine("Введите 5 оценок:");
                for (int j = 0; j < grades.Length; j++)
                {
                    Console.Write($"Оценка {j + 1}: ");
                    grades[j] = int.Parse(Console.ReadLine());
                }
                // Инициализация студента
                students[i] = new Student
                {
                    LastName = lastName,
                    Initials = initials,
                    GroupNumber = groupNumber,
                    Grades = grades
                };
            }
            // Сортировка студентов по возрастанию среднего балла
            var sortedStudents = students.OrderBy(s => s.GetAverageGrade()).ToArray();
            // Вывод отсортированных студентов
            Console.WriteLine("\nСтуденты, отсортированные по возрастанию среднего балла:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.LastName} ({student.Initials}), группа: {student.GroupNumber}, средний балл: {student.GetAverageGrade():F2}");
            }
            // Вывод студентов, у которых все оценки равны 4 или 5
            Console.WriteLine("\nСтуденты с оценками только 4 или 5:");
            foreach (var student in sortedStudents)
            {
                if (student.HasOnlyHighGrades())
                {
                    Console.WriteLine($"{student.LastName} ({student.Initials}), группа: {student.GroupNumber}");
                }
            }
        }
    }

}


using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace _9._1
{
    internal class Program
    {
        static string filePath = "students.json";
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            LoadStudents();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Управление списком студентов ===");
                Console.WriteLine("1. Добавить студента");
                Console.WriteLine("2. Удалить студента");
                Console.WriteLine("3. Редактировать студента");
                Console.WriteLine("4. Показать всех студентов");
                Console.WriteLine("5. Поиск студента");
                Console.WriteLine("6. Сортировать студентов");
                Console.WriteLine("7. Сохранить и выйти");
                Console.Write("Выберите действие: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": AddStudent(); break;
                    case "2": RemoveStudent(); break;
                    case "3": EditStudent(); break;
                    case "4": ShowStudents(); break;
                    case "5": SearchStudent(); break;
                    case "6": SortStudents(); break;
                    case "7":
                        SaveStudents();
                        Console.WriteLine("Список сохранён. Выход...");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }

                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }

        // ====== КЛАСС СТУДЕНТА ======
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Group { get; set; }
        }

        // ====== ДОБАВЛЕНИЕ ======
        static void AddStudent()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Введите группу: ");
            string group = Console.ReadLine();

            int newId = 1;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id >= newId)
                    newId = students[i].Id + 1;
            }

            Student newStudent = new Student
            {
                Id = newId,
                Name = name,
                Age = age,
                Group = group
            };

            students.Add(newStudent);
            Console.WriteLine("Студент добавлен!");
        }

        // ====== УДАЛЕНИЕ ======
        static void RemoveStudent()
        {
            ShowStudents();
            Console.Write("Введите ID студента для удаления: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                int index = -1;
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].Id == id)
                    {
                        index = i;
                        break;
                    }
                }

                if (index != -1)
                {
                    students.RemoveAt(index);
                    Console.WriteLine("Студент удалён!");
                }
                else
                {
                    Console.WriteLine("Студент не найден!");
                }
            }
        }

        // ====== РЕДАКТИРОВАНИЕ ======
        static void EditStudent()
        {
            ShowStudents();
            Console.Write("Введите ID студента для редактирования: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Student found = null;
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].Id == id)
                    {
                        found = students[i];
                        break;
                    }
                }

                if (found != null)
                {
                    Console.Write($"Имя ({found.Name}): ");
                    string name = Console.ReadLine();
                    if (!string.IsNullOrEmpty(name)) found.Name = name;

                    Console.Write($"Возраст ({found.Age}): ");
                    string ageStr = Console.ReadLine();
                    if (int.TryParse(ageStr, out int newAge)) found.Age = newAge;

                    Console.Write($"Группа ({found.Group}): ");
                    string group = Console.ReadLine();
                    if (!string.IsNullOrEmpty(group)) found.Group = group;

                    Console.WriteLine("Данные обновлены!");
                }
                else
                {
                    Console.WriteLine("Студент не найден!");
                }
            }
        }

        // ====== ВЫВОД ======
        static void ShowStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Список студентов пуст.");
                return;
            }

            Console.WriteLine("\nID\tИмя\t\tВозраст\tГруппа");
            for (int i = 0; i < students.Count; i++)
            {
                Student s = students[i];
                Console.WriteLine($"{s.Id}\t{s.Name}\t\t{s.Age}\t{s.Group}");
            }
        }

        // ====== ПОИСК ======
        static void SearchStudent()
        {
            Console.Write("Введите часть имени или группы: ");
            string query = Console.ReadLine().ToLower();

            bool foundAny = false;

            for (int i = 0; i < students.Count; i++)
            {
                string nameLower = students[i].Name.ToLower();
                string groupLower = students[i].Group.ToLower();

                if (nameLower.Contains(query) || groupLower.Contains(query))
                {
                    if (!foundAny)
                    {
                        Console.WriteLine("\nРезультаты поиска:");
                        foundAny = true;
                    }

                    Console.WriteLine($"{students[i].Id}: {students[i].Name}, {students[i].Age} лет, группа {students[i].Group}");
                }
            }

            if (!foundAny)
                Console.WriteLine("Совпадений не найдено.");
        }

        // ====== СОРТИРОВКА ======
        static void SortStudents()
        {
            Console.WriteLine("Сортировать по:");
            Console.WriteLine("1. Имени");
            Console.WriteLine("2. Возрасту");
            Console.WriteLine("3. Группе");
            Console.Write("Выбор: ");
            string choice = Console.ReadLine();

            // простой пузырьковый алгоритм сортировки
            for (int i = 0; i < students.Count - 1; i++)
            {
                for (int j = 0; j < students.Count - i - 1; j++)
                {
                    bool needSwap = false;

                    if (choice == "1" && string.Compare(students[j].Name, students[j + 1].Name) > 0)
                        needSwap = true;
                    else if (choice == "2" && students[j].Age > students[j + 1].Age)
                        needSwap = true;
                    else if (choice == "3" && string.Compare(students[j].Group, students[j + 1].Group) > 0)
                        needSwap = true;

                    if (needSwap)
                    {
                        Student temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Список отсортирован!");
        }

        // ====== СОХРАНЕНИЕ ======
        static void SaveStudents()
        {
            string json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        // ====== ЗАГРУЗКА ======
        static void LoadStudents()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                List<Student> loaded = JsonSerializer.Deserialize<List<Student>>(json);
                if (loaded != null)
                    students = loaded;
            }
        }
    }
}

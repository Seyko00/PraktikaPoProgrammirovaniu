using System;
using System.Linq;
namespace Задание_2
{
    public struct Student
    {
        public string LastName { get; set; }  // Фамилия студента
        public string Initials { get; set; }  // Инициалы студента
        public int GroupNumber { get; set; }  // Номер группы
        public int[] Grades { get; set; }     // Успеваемость (оценки)
        // Метод для расчета среднего балла
        public double GetAverageGrade()
        {
            return Grades.Average();  // Возвращаем среднее значение из массива оценок
        }
        // Метод для проверки, что все оценки равны 4 или 5
        public bool HasOnlyHighGrades()
        {
            return Grades.All(grade => grade == 4 || grade == 5);
        }
    }

}

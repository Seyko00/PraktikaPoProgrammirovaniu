using System;
class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя возраст
        Console.Write("Введите ваш возраст: ");
        double E = Convert.ToDouble(Console.ReadLine());
        // Проверяем возраст пользователя
        if (E < 18)
        {
            Console.WriteLine("Вам меньше 18, вы не можете получить водительские права!");
        }
        else if (E == 18)
        {
            Console.WriteLine("Вам 18 лет, вы не можете получить права!");
        }
        else
        {
            // Выводим сообщение, если возраст больше 18
            Console.WriteLine("Вы можете получить водительские права!");
        }
        Console.ReadKey();
    }
}

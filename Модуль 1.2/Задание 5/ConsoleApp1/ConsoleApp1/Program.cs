using System;
using System.Linq; // Для использования метода Contains
class Program
{
    static void Main()
    {
        // Ввод значения K
        Console.Write("Введите количество элементов массива K: ");
        int K = int.Parse(Console.ReadLine());
        // Определение согласных и гласных букв русского алфавита
        char[] consonants = { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };
        char[] vowels = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
        // Инициализация символьного массива и генерация случайных букв
        char[] array = new char[K];
        Random random = new Random();
        // Символы русского алфавита
        char[] russianAlphabet = "абвгдеёжзийклмнопрстуфхцчшщыэюя".ToCharArray();
        Console.WriteLine("\nСгенерированный массив:");
        for (int i = 0; i < K; i++)
        {
            array[i] = russianAlphabet[random.Next(0, russianAlphabet.Length)];
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        // Создание нового массива с согласными буквами
        char[] consonantArray = array.Where(c => consonants.Contains(c)).ToArray();
        // Вывод массива согласных
        Console.WriteLine("\nМассив согласных букв:");
        foreach (char c in consonantArray)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
    }
}

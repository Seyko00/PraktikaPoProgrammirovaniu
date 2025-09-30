using System;
using static System.Console;
class Program
{
    static void Main()
    {
        int n = 5; // Размер матрицы
        int[,] matrix = new int[n, n];
        Random rand = new Random();
        // Заполнение матрицы случайными значениями
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                matrix[i, j] = rand.Next(-50, 51);
        }
        // Вывод исходной матрицы
        WriteLine("Исходная матрица:");
        PrintMatrix(matrix);
        // Сортировка строк по суммам
        int[] rowSums = new int[n];
        for (int i = 0; i < n; i++)
            rowSums[i] = GetRowSum(matrix, i);
        // Создание массива индексов для сортировки
        int[] indices = new int[n];
        for (int i = 0; i < n; i++)
            indices[i] = i;
        // Сортировка индексов на основе сумм строк
        Array.Sort(rowSums, indices);
        // Создание новой матрицы для отсортированных строк
        int[,] sortedMatrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            int rowIndex = indices[i];
            for (int j = 0; j < n; j++)
                sortedMatrix[i, j] = matrix[rowIndex, j];
        }
        // Вывод отсортированной матрицы
        WriteLine("\nМатрица после сортировки по суммам строк:");
        PrintMatrix(sortedMatrix);
    }
    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Write(matrix[i, j] + "\t");
            WriteLine();
        }
    }
    static int GetRowSum(int[,] matrix, int rowIndex)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
            sum += matrix[rowIndex, j];
        return sum;
    }
}

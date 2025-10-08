namespace Задание_5
{
    public class Sorter
    {
        // Метод сортировки пузырьком
        public static void BubbleSort(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Обмен
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        // Метод быстрой сортировки
        public static void QuickSort(int[] array, int left, int right)
        {
            int i = left, j = right;
            int pivot = array[(left + right) / 2];

            while (i <= j)
            {
                while (array[i] < pivot) i++;
                while (array[j] > pivot) j--;

                if (i <= j)
                {
                    // Обмен
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            // Рекурсивные вызовы
            if (left < j)
                QuickSort(array, left, j);
            if (i < right)
                QuickSort(array, i, right);
        }
    }
}

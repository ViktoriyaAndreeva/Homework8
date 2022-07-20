namespace Homework8
{
    class Task54
    {
        // Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // В итоге получается вот такой массив:
        // 1 2 4 7
        // 2 3 5 9
        // 2 4 4 8
        public static void Main()
        {
            Console.WriteLine("Введите количество строк");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"В массиве строк: {m}");
            Console.WriteLine("Введите количество столбцов");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"В массиве столбцов: {n}");

            int[,] array = new int[m, n];

            FillArray(array, m, n);
            PrintArray(array);
            SortArray(array);
            Console.WriteLine("Отсортированный массив");
            PrintArray(array);
            // 

        }
        public static void FillArray(int[,] array, int m, int n)
        {
            Random rnd = new Random();
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToInt32(rnd.Next(0, 10));
                }
            }
        }
        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void SortArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(1) - 1; k++)
                        if (array[i, k] > array[i, k + 1])
                        {
                            int max = array[i, k];
                            array[i, k] = array[i, k + 1];
                            array[i, k + 1] = max;
                        }
                }
            }
        }
    }

}





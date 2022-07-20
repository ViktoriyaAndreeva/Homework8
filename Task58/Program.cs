namespace Homework8
{
    class Task58
    {
        //         Задайте две матрицы. Напишите программу, которая выведет матрицу произведения элементов двух предыдущих матриц.
        // Например, заданы 2 массива:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 5 2 6 7
        // и
        // 1 5 8 5
        // 4 9 4 2
        // 7 2 2 6
        // 2 3 4 7
        // Их произведение будет равно следующему массиву:
        // 1 20 56 10
        // 20 81 8 6
        // 56 8 4 24
        // 10 6 24 49

        public static void Main()
        {
            Console.WriteLine("Введите количество строк");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"В массиве строк: {m}");
            Console.WriteLine("Введите количество столбцов");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"В массиве столбцов: {n}");

            int[,] array = new int[m, n];
            int[,] array2 = new int[m, n];

            FillArray(array, m, n);
            Console.WriteLine("1 массив");
            PrintArray(array);
            FillArray(array2, m, n);
            Console.WriteLine("2 массив");
            PrintArray(array2);
            Console.WriteLine("Помноженный массив");
            PrintArray(MultiplierArray(array, array2));

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
        public static int[,] MultiplierArray(int[,] array, int[,] array2)
        {
            int[,] multi = new int[array.GetLength(0), array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    multi[i, j] = array[i, j] * array2[i, j];
                }
            }
            return multi;
        }
    }
}







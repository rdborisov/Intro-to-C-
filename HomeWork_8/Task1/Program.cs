/* Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
namespace Homework8
{
    class Task1
    {
        public static void Main()
        {
            Console.Clear();
            int rows = 3,
                columns = 4;

            int[,] matrix = CreateMatrix(rows, columns); //new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
            PrintMatrix(matrix);
            Console.WriteLine();
            matrix = SortMatrix(matrix);
            PrintMatrix(matrix);
        }

        public static int[,] CreateMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = new Random().Next(0, 10);
                }
            }
            return matrix;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static int[,] SortMatrix(int[,] matrix)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int n = 0; n < matrix.GetLength(1) - 1; n++)
                    {
                        if (matrix[i, n] < matrix[i, n + 1])
                        {
                            int temp = matrix[i, n];
                            matrix[i, n] = matrix[i, n + 1];
                            matrix[i, n + 1] = temp;
                        }
                    }
                }

            }
            return matrix;
        }

    }
}

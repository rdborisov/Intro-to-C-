/* Задача 4. (*) Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

namespace HomeWork8
{
    class Task4
    {
        public static void Main()
        {
            int size = 4;
            SpiralOutput(size);
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 10) Console.Write($" {matrix[i, j]} ");
                    else Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void SpiralOutput(int size)
        {
            
            int value = 1;
            int i = 0, j = 0;
            int[,] matrix = new int[size, size];
            
            while (size != 0)
            {
                int k = 0;
                do { matrix[i, j++] = value++; } while (++k < size - 1);
                for (k = 0; k < size - 1; k++) matrix[i++, j] = value++;
                for (k = 0; k < size - 1; k++) matrix[i, j--] = value++;
                for (k = 0; k < size - 1; k++) matrix[i--, j] = value++;

                ++i; ++j; size = size < 2 ? 0 : size - 2;
            }
            PrintMatrix(matrix);
        }
    }
}
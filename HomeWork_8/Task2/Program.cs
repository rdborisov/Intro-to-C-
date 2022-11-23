/* Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2 
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

1 4 7 2 //1+4+7+2=14
5 9 2 3 //5+9+2+3=19
8 4 2 4 //8+4+2+4=18
5 2 6 7 //5+2+6+7=20 
Output: 1 строка
*/

namespace HomeWork8
{
    class Task2
    {
        public static void Main()
        {
            int size = 4;
            int[,] RectangularMatrix = CreateRectangularMatrix(size); //new int[4, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };//
            PrintMatrix(RectangularMatrix);
            int[] sumOfRows = SumOfRows(RectangularMatrix);
            int minIndex = FindIndexMinSumOfRows(sumOfRows);
            Console.WriteLine($"Наименьшая сумма элементов в: {minIndex} строке");
        }

        public static int[,] CreateRectangularMatrix(int size)
        {
            int[,] matrix = new int[size, size];

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

        public static int[] SumOfRows(int[,] matrix)
        {
            int[] SumOfRows = new int[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    SumOfRows[i] += matrix[i, j];
                }
            }
            return SumOfRows;
        }

        public static int FindIndexMinSumOfRows(int[] array)
        {
            int min = array[0];
            int indexMin = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i]) 
                {
                    min = array[i];
                    indexMin = i;
                }
            }
            return indexMin + 1;
        }
   
    
    }
}
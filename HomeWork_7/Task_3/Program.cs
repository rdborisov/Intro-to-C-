/*
Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

class H7T3
{
    public static void Main()
    {
        int[,] CreateMatrix(int m, int n, int min, int max)     //Создание двумерного массива "матрицы"
        {
            int[,] Matrix = new int[m, n];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[i, j] = new Random().Next(min, max);
                }
            }
            return Matrix;
        }

        void PrintMatrix(int[,] Matrix)                         //Печать двумерного массива
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write($"{Matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        void PrintArray(double[] Array)                         //Печать двумерного массива
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write($"{Array[i]} ");
            }
        }


        double[] ColumnAVG(int[,] Matrix, int Round)
        {

            double[] Array = new double[Matrix.GetLength(1)];

            for (int i = 0; i < Matrix.GetLength(1); i++)
            {

                double sum = 0;
                for (int j = 0; j < Matrix.GetLength(0); j++)
                {
                    sum += Matrix[j, i];

                }
                Array[i] = Math.Round(sum / Matrix.GetLength(0), Round);

            }
            return Array;
        }

        void Output()
        {
            int[,] Matrix = CreateMatrix(4, 4, 0, 5);           //(строки, столбцы, min, max)
            PrintMatrix(Matrix);
            double[] AVG = ColumnAVG(Matrix, 1);                //(Массив, округление)
            Console.Write($"Среднее арифметическое каждого столбца: "); 
            PrintArray(AVG);
        }
        Output();
    }
}

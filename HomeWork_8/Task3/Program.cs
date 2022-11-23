/* Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

namespace HomeWork8
{
    class Task3
    {
        public static void Main()
        {
            Console.Clear();
            int[,] matrixA = CreateMatrix(2, 2);
            int[,] matrixB = CreateMatrix(2, 2);
            PrintMatrix(matrixA);
            Console.WriteLine("---");
            PrintMatrix(matrixB);
            Console.WriteLine("---");

            if (VerificationMultiplication(matrixA, matrixB))
            {
                int[,] result = MultiplicationMatrix(matrixA, matrixB);
                PrintMatrix(result);
            }
            else Console.WriteLine($"Произведение матриц невозможно, матрицы несогласованы");

        }

        public static int[,] CreateMatrix(int rows, int collums)
        {
            int[,] matrix = new int[rows, collums];

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

        public static bool VerificationMultiplication(int[,] matrixA, int[,] matrixB)
        {
            return (matrixA.GetLength(1) == matrixB.GetLength(0)) ? true : false;
        }

        public static int[,] MultiplicationMatrix(int[,] matrixA, int[,] matrixB)
        {
            if (matrixA.GetLength(0) > matrixB.GetLength(1))
            {
                int[,] result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

                for (int i = 0; i < matrixA.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixB.GetLength(1); j++)
                    {

                        for (int k = 0; k < result.GetLength(0); k++)
                        {
                            result[i, j] += matrixA[i, k] * matrixB[k, j];
                        }
                    }
                }
                return result;
            }
            else 
            {
                int[,] result = new int[matrixA.GetLength(1), matrixB.GetLength(0)];

                for (int i = 0; i < matrixA.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixB.GetLength(1); j++)
                    {

                        for (int k = 0; k < result.GetLength(0); k++)
                        {
                            result[i, j] += matrixA[i, k] * matrixB[k, j];
                        }
                    }
                }
                return result;
            }
        }
    }
}
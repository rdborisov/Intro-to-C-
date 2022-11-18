/*
Задача 1. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

class H7T1
{
    public static void Main()
    {
        int UserInput(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        double[,] CreateMatrix(int m, int n, int max, int min)
        {
            double[,] Matrix = new double[m, n];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[i, j] = new Random().NextDouble() * (max - min) + min;
                }
            }
            return Matrix;
        }

        void PrintMatrix(double[,] Matrix)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write($"{Matrix[i, j]:f1} ");
                }
                Console.WriteLine();
            }
        }

        void Output()
        {
            double[,] Matrix = CreateMatrix(UserInput("m := "), UserInput("n := "), -5, 10);
            PrintMatrix(Matrix);
        }
        Output();
    }
}

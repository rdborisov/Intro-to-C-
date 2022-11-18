/*
Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
1 2 3
3 4 5
3+5=8, 1+2+3=6, 8-6=2
*/
class H6T3
{
    public static void Main()
    {
        int[,] CreateMatrix(int column, int row)
        {
            int[,] Matrix = new int[row, column];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[i, j] = new Random().Next(1, 10);
                }
            }
            return Matrix;
        }

        void PrintMatrix(int[,] Matrix)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        int SumMaxArray(int[,] Matrix) // Сумма максимумов.
        {
            int sum = 0;
            for (int j = 0; j < Matrix.GetLength(0); j++)
            {
                int max = Matrix[j, 0];
                for (int i = 0; i < Matrix.GetLength(1); i++)
                {
                    if (max < Matrix[j, i])
                    {
                        max = Matrix[j, i];
                    }
                }
                sum += max;
            }
            return sum;
        }

        int SumMinArray(int[,] Matrix) // Сумма минимумов.
        {
            int sum = 0;
            for (int j = 0; j < Matrix.GetLength(1); j++)
            {
                int min = Matrix[0, j];
                for (int i = 0; i < Matrix.GetLength(0); i++)
                {
                    if (min > Matrix[i, j])
                    {
                        min = Matrix[i, j];
                    }
                }
                sum += min;
            }
            return sum;
        }

        int DiffMaxMin(int[,] Matrix)
        {
            return SumMaxArray(Matrix) - SumMinArray(Matrix);
        }

        void Output()
        {
            int[,] Matrix = CreateMatrix(4, 4);
            PrintMatrix(Matrix);
            Console.WriteLine("Sum Max: " + SumMaxArray(Matrix));
            Console.WriteLine("Sum Min: " + SumMinArray(Matrix));
            Console.WriteLine("Diff MaxMin:" + DiffMaxMin(Matrix));
        }

        Output();
    }
}
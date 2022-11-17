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
        int[,] CreateMatrix(int row, int column)
        {
            int[,] Array = new int[row, column];

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Array[i, j] = new Random().Next(1, 100);
                }

            }
            return Array;
        }

        void PrintMatrix(int[,] Array)
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Console.Write($"{Array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        void PrintArr(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write($"{Array[i]} ");
            }
            Console.WriteLine();
        }

        void DiffMaxMin(int[,] Array)
        {
            //int max = Array[0, 0];

            int[] maxArray = new int[Array.GetLength(0)];
            for (int i = 0; i < Array.GetLength(0); i++) //name.GetLength(0) - возвращает количество строк в матрице
            {
                for (int j = 0; j < maxArray.Length; j++)
                {
                    if (maxArray[j] < Array[0, i]) maxArray[0] = Array[0, i];
                }
                
                
                
                

            }
            PrintArr(maxArray);

        }


        int row = 3;
        int column = 3;
        int[,] Array = CreateMatrix(row, column);
        PrintMatrix(Array);
        Console.WriteLine();
        DiffMaxMin(Array);

    }
}
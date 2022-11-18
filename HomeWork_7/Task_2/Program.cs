/*Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
class H7T2
{
    public static void Main()
    {

        int[] UserInputArray(string message)                    //Ввод пользователем массива для индексации "матрицы"
        {
            Console.Write(message);
            char[] SplitChar = new char[] { ',', ' ' }; 
            int[] UserInput = Array.ConvertAll(Console.ReadLine().Split(SplitChar,
                            StringSplitOptions.RemoveEmptyEntries), int.Parse);
            if (UserInput.Length < 2) return UserInputArray(message);
            else return UserInput;
        }

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

        void PrintArray(int[] Array)                           //Печать одномерного массива
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                Console.Write($"{Array[i]} ");
            }
            Console.WriteLine();
        }

        void PrintByIndex(int[] indexArray, int[,] Matrix)      //Поиск и вывод индекса двумерного массива
        {
             
            if (Matrix.GetLength(0) < indexArray[0] || Matrix.GetLength(1) < indexArray[1] 
                                                    || indexArray[0] < 0 || indexArray[1] < 0)
                Console.WriteLine($"{indexArray[0]}, {indexArray[1]}-> такого числа в массиве нет");
            else 
            Console.WriteLine($"{indexArray[0]}, {indexArray[1]} -> {Matrix[indexArray[0], indexArray[1]]}");
        }

        void Output()                                           //Фкнкция вывода
        {
            int[,] Matrix = CreateMatrix(3, 3, -10, 10);
            PrintMatrix(Matrix);
            int[] indexArray = UserInputArray("Введите индекс(2 числа) через пробел и нажмите Enter: ");
            PrintByIndex(indexArray, Matrix);
        }
        Output();
    }
}
/*Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
class H5T1
{
    public static void Main()
    {
        int[] CreateArr(int Length)
        {
        int[] Array = new int[Length];
        for(int i = 0; i < Array.Length; i++)
        {
            Array[i] = new Random().Next(100,1000);
        }
        return Array;
        }

        void PrintArr(int[] Array)
        {
            for(int i = 0; i < Array.Length; i++)
            {
                Console.Write($"{Array[i]} ");
            }
        }

        int FindEvenNum(int[] Array)
        {
            int count = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 2 == 0) count++;
            }
            return count;
        }

        void Output()
        {
            int Length = 5;
            int[] Array = CreateArr(Length);
            int EvenCount = FindEvenNum(Array);
            Console.Write($"[ ");
            PrintArr(Array);
            Console.Write($"] -> {EvenCount}");
        }

        Output();
    }
}


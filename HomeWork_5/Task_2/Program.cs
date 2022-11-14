/*Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19\
[-4, -6, 89, 6] -> 0
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
                Array[i] = new Random().Next(-100,101);
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

        int SumOfOddPos(int[] Array)
        {
            int Sum = 0;
            for (int i = 1; i < Array.Length; i += 2)
            {
                Sum += Array[i];
            }
            return Sum;
        }

        void Output()
        {
            int Length = 256;
            int[] Array = CreateArr(Length);
            PrintArr(Array);
            int SumOdd = SumOfOddPos(Array);
            Console.WriteLine("");
            Console.WriteLine($"{SumOdd}");
        }
        Output();
    }

}

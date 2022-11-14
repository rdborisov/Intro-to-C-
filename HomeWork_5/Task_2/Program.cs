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
                Array[i] = new Random().Next(-99,100);
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


    }

}

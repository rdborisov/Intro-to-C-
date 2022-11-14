/*Задача 3: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

class H5T3
{
    public static void Main()
    {
        int[] CreateArr(int Length)
        {
            int[] Array = new int[Length];
            for(int i = 0; i < Array.Length; i++)
            {
                Array[i] = new Random().Next(0,100);
            }
            return Array;
        }

        static void PrintArr(int[] Array, int i)
        {
            Console.Write($"{Array[i]} ");
            if (i == Array.Length - 1){
                Console.WriteLine();
            }
            else{
                PrintArr(Array, i + 1);
            }
        }

        int DiffMinMax(int[] Array)
        {
            int FindMin(int[] Array, int Min, int i = 0)
            {
                if (i >= Array.Length) return Min;
                return FindMin(Array, Min > Array[i] ? Array[i] : Min, i + 1);
            }
            int FindMax(int[] Array, int Max, int i = 0)
            {
                if (i >= Array.Length) return Max;
                return FindMax(Array, Max < Array[i] ? Array[i] : Max, i + 1);
            }
            
            return FindMax(Array, Array[0]) - FindMin(Array, Array[0]);
        }
        
        void Output()
        {
            int Length = 8;
            int[] Array = CreateArr(Length);
            PrintArr(Array, 0);
            Console.WriteLine($"-> {DiffMinMax(Array)}");
           
        }
        Output();
    }

}
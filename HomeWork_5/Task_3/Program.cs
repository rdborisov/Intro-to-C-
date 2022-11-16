/*Задача 3: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

class H5T3
{
    public static void Main()
    {
        double[] CreateArr(int Length)
        {
            double[] Array = new double[Length];
            for(int i = 0; i < Array.Length; i++)
            {
                Array[i] = new Random().NextDouble() * 10;
            }
            return Array;
        }

        static void PrintArr(double[] Array, int i)
        {
            Console.Write($"{Array[i]:f2} ");
            if (i == Array.Length - 1){
                Console.WriteLine();
            }
            else{
                PrintArr(Array, i + 1);
            }
        }

        double DiffMinMax(double[] Array)
        {
            double FindMin(double[] Array, double Min, int i = 0)
            {
                if (i >= Array.Length) return Min;
                return FindMin(Array, Min > Array[i] ? Array[i] : Min, i + 1);
            }
            double FindMax(double[] Array, double Max, int i = 0)
            {
                if (i >= Array.Length) return Max;
                return FindMax(Array, Max < Array[i] ? Array[i] : Max, i + 1);
            }
            
            return FindMax(Array, Array[0]) - FindMin(Array, Array[0]);
        }
        
        void Output()
        {
            int Length = 8;
            double[] Array = CreateArr(Length);
            PrintArr(Array, 0);
            Console.WriteLine($"-> {DiffMinMax(Array):f2}");
           
        }
        Output();
    }

}
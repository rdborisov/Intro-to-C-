/*Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

class H4T3
{
    public static void Main()
    {
        int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        int VerifLength(int Input)
        {
            if (Input == 0 || Input < 0) 
            {
                Console.WriteLine("Wrong length array");
                return 1;
            }
            return Input;
        }

        int[] CreateArr(int Length, int InputMin, int InputMax)
        {
            int[] tempArray = new int[Length];
            for (int i = 0; i < Length; i++)
            {
                tempArray[i] = new Random().Next(InputMin, InputMax);
            }
            return tempArray;
        }

        void PrintArr(int[] tempArray)
        {
            for (int i = 0; i < tempArray.Length; i++)
            {
                Console.Write($"{tempArray[i]} ");
            }
        }
        
        int SecondMax(int[] tempArray)
        {
            int Max =  tempArray[0];
            int SecondMax = tempArray[tempArray.Length - 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                if (Max < tempArray[i])
                {
                    SecondMax = Max;
                    Max = tempArray[i];
                }
                else if (tempArray[i] > SecondMax && tempArray[i] < Max)
                {
                    SecondMax = tempArray[i];
                }
            }
            
            return SecondMax;
        }

        void Output()
        {
            Console.Clear();
            int Length = VerifLength(Input("Array Length: ")); 
            int[] UserArray = CreateArr(Length, Input("Random Min: "), Input("Random Max: ") + 1); 
            PrintArr(UserArray);
            Console.WriteLine();
            Console.WriteLine($"Second Max: {SecondMax(UserArray)}");
        }
        
        Output();
    }
}


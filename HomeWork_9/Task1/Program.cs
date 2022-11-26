/*
Задача 1: Задайте значения M и N. 
Напишите программу, которая выведет все чётные натуральные 
числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

namespace HomeWork9
{
    class Task1
    {
        public static void Main()
        {
            int m = 1,//UserInput("M: "),
                n = 10;//UserInput("N: ");
            Console.Write($"M = {m}; N = {n} -> ");
            PrintEvenNumbers(m, n);


        }

        public static int UserInput(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public static void PrintEvenNumbers(int m, int n)
        { 
            if (m <= n) 
            {
                if (m % 2 == 0) 
                {
                    Console.Write($"{m} ");
                }
            }
            else return;
            PrintEvenNumbers(m + 1, n);
        }

    }
}
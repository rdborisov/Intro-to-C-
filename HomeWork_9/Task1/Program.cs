﻿/*
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
            int m = UserInput("M: "),
                n = UserInput("N: ");
            Console.Write($"M = {m}; N = {n} -> ");
            PrintingEvenNumbers(m, n);


        }

        public static int UserInput(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public static void PrintingEvenNumbers(int m, int n)
        {
            if (m > n)
            {
                return;
            }
            if (m % 2 == 0) Console.Write($"{m} ");
            
            PrintingEvenNumbers(m + 1, n);
            
        }

    }
}
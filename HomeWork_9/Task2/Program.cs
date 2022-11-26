/*
Задача 2: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в 
промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

namespace HomeWork9
{
    class Task2
    {
        public static void Main()
        {
            int m = UserInput("M: "),
                n = UserInput("N: ");
            Console.Write($"M = {m}; N = {n} -> ");
            Console.Write(SumInBeetween(m, n));
        }

        public static int UserInput(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public static int SumInBeetween(int m, int n, int sum = 0)
        {
            if (m <= n)
            {
                sum += m;
                return SumInBeetween(m + 1, n, sum);
            }
            else
            {
                return sum;
            }
        }
    }
}
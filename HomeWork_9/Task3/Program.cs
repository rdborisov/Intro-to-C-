/*
Задача 3: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

namespace HomeWork9
{
    class Task3
    {
        public static void Main()
        {
            int m = UserInput("M: "),
                n = UserInput("N: ");
            Console.Write($"M = {m}; N = {n} -> ");
            Console.Write(Akkerman(m, n));
        }

        public static int UserInput(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public static int Akkerman(int m, int n)
        {
            if (m == 0)
                return n + 1;
            else
              if ((m != 0) && (n == 0))
                return Akkerman(m - 1, 1);
            else
                return Akkerman(m - 1, Akkerman(m, n - 1));
        }

    }
}
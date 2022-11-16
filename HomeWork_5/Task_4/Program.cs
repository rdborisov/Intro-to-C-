/*Задача 4 (*) При помощи рекурсии вывести последовательность чисел, 
с заданым количеством этих чисел по принципу:
Ввожу => 12
1 2 2 3 3 3 4 4 4 4 5 5
*/

class H5T4
{
    public static void Main()
    {
        int RecSeqNum(int n)
        {
            int sum = 0;
            int j = 0;
            if (n == 1)
            {
                Console.Write(1);
                return 0;
            }
            else
            {
                for (int i = 1; sum < n; i++)
                {
                    sum += i;
                    j = i;
                }
                Console.Write(RecSeqNum(--n) + j);
                return 0;
            }

        }

        RecSeqNum(12);
    }
}
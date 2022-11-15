/*Задача 4 (*) При помощи рекурсии вывести последовательность чисел, 
с заданым количеством этих чисел по принципу:
Ввожу => 12
1 2 2 3 3 3 4 4 4 4 5 5
*/

class H5T4
{
    public static void Main()
    {
        /*int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }*/

        void RecSeqNum(int Num)
        {
            for (int i = 1; i <= Num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i} ");
                }
            }
            
        }
        void Output()
        {
            RecSeqNum(6);
        }
        Output();
    }
}
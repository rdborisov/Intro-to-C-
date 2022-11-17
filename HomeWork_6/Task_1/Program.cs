/*
Задача 1: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2 
1, -7, 567, 89, 223-> 3
*/

class H6T1
{
    public static void Main()
    {
        // Функция записи из консольной строки с разделением через пробел/пробелы
        // Символ-разделитель добавляется в массив SplitChar и используется в функции Split(char[], StringSplitOptions)
        // StringSplitOptions.RemoveEmptyEnties - удаляет повторяющийся ввод пробелов
        int[] UserInputArray(string message) 
            {
                Console.Write(message);

                char[] SplitChar= new char[]{' '}; // Массив символов разделителей

                return Array.ConvertAll(Console.ReadLine().Split(SplitChar, 
                                StringSplitOptions.RemoveEmptyEntries), int.Parse);                           
            }

        int FindPositeveNums(int[] Array)
        {
            int count = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > 0) count++;
            }
            return count;
        }

        void PrintArr(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write($"{Array[i]} ");
            }
            Console.WriteLine();
        }

        void Output()
        {
            int[] UserNum = UserInputArray("Введите числа через пробел и нажмите Enter ");
            PrintArr(UserNum);
            Console.Write($"Положительных чисел: {FindPositeveNums(UserNum)}");
        }
        Output();
    }
}
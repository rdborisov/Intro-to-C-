/*Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
class H4T2
{

    public static void Main()
    {
        int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        
        int ValidateNumber(int Input)
        {
            if (Input < 0) Input *= -1;
            return Input;
        }
        
        int SumNum(int Num)
        {
            int Sum = 0;
            while(Num > 0) 
            {
                int lastDigit = Num % 10;
                Sum += lastDigit;
                Num /= 10;
            }
            return Sum;
        }

        void Output()
        {
            Console.Clear();
            int Num = ValidateNumber(Input("Input Num: "));
            Console.WriteLine($"{Num} -> {SumNum(Num)}");
        }
        
        Output();
    }
}
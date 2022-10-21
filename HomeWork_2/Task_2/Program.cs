/*Задача 2: Напишите программу, которая выводит случайное трёхзначное число 
и удаляет вторую цифру этого числа. Не использовать строки для расчета.
456 -> 46
782 -> 72
918 -> 98
*/
Console.Clear();

void Launch()
{
    int Num = new Random().Next(100, 1000);
     if (Num / 100 > 0 && Num / 100 < 10)
    {
        int DigitOne = Num / 100;
        int DigitTwo = Num % 10;
        int NumOutTwoDigit = Convert.ToInt32($"{DigitOne}{DigitTwo}");
        Console.WriteLine($"{Num} -> {NumOutTwoDigit}");
        
    }
    else Console.WriteLine("Число не 3-х значное");
}

Launch();
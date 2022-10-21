/*Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.
456 -> 5
782 -> 8
918 -> 1
*/
Console.Clear();

int Prompt(string mesage)
{
    Console.Write(mesage);
    return int.Parse(Console.ReadLine()); 
}

void TwoDigit()
{
    int Num = Prompt("Введите 3-х значное число: ");
    if (Num / 100 > 0 && Num / 100 < 10)
    {
        int TwoDigit = Num / 10 % 10;
        Console.WriteLine($"{Num} -> {TwoDigit}");
    }
    else Console.WriteLine("Число не трёхзначное");
}

TwoDigit();
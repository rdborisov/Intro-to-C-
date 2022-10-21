/*Задача 1 Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом. Без использования строк
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Clear();

int Prompt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

void Launch()
{
    int Num = Prompt("Введите 5-и значное число: ");
    if (Num / 10000 != 0 && Num / 10000 < 10)
    {
        if (Num / 10000 == Num % 10)
        {
            if (Num / 1000 % 10 == Num / 10 % 10) Console.WriteLine($"{Num} -> Да, палиндром");
            else Console.WriteLine($"{Num} -> Нет, не палиндром");
        }
        else Console.WriteLine($"{Num} -> Нет, не палиндром");
    }
    else Console.WriteLine($"{Num} -> Не пятизначное");
    
}

Launch();



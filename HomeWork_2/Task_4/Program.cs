/*Задача 4: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void Launch()
{
    int Num = Prompt("Введите день недели цифрой(1...7): ");
    if (Num < 1 || Num > 7) Console.WriteLine("Введёное число не является днём недели");
    else if (Num >= 6) Console.WriteLine($"{Num} -> Да");
    else Console.WriteLine($"{Num} -> Нет");
}

Launch();
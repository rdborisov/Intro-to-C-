/*Задача 3 Напишите программу, которая принимает 
на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.Clear();

double Launch()
{   
    int Prompt(string msg)
    {
        Console.Write(msg);
        return int.Parse(Console.ReadLine());
    }
    
    int Num = Prompt("Введите целое число: ");
    double CubeNumber = Num;
    Console.Write($"{Num} -> ");
    for (int i = 1; i <= Num; i++)
    {
        CubeNumber = Math.Pow(i, 3);
        if (i < Num) Console.Write($"{CubeNumber}, ");
        else Console.Write($"{CubeNumber}");
    }
    return CubeNumber;
}
    
Launch();
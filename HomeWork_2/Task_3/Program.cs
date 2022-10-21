/*Задача 3: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет. Не использовать строки для расчета.
645 -> 5
78 -> третьей цифры нет
326792 -> 6
*/

Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void Launch()
{
    
    int Num = Prompt("Введите целое число: ");
    int NumOne = Num;
    if (Num < 100) Console.WriteLine($"{NumOne} -> Третьей цифры нет");
    else 
    {
        while (Num > 1000)
        {
            Num = Num / 10;
        }
        Num = Num % 10;
        Console.WriteLine($"{NumOne} -> {Num}");
    }
    
}
Launch();


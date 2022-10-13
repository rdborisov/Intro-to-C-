/*Задача 2: Напишите программу, которая на вход принимает
 два числа и выдаёт, какое число большее, а какое меньшее.*/

Console.Write("Введите 1-е число: ");
double NumOne = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 2-е число: ");
double NumTwo = Convert.ToDouble(Console.ReadLine());
if (NumOne == NumTwo) Console.WriteLine("Числа равны");
else if (NumOne > NumTwo) Console.WriteLine($"{NumOne} > {NumTwo}");
else Console.WriteLine($"{NumOne} < {NumTwo}");
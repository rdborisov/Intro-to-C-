/*Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

using System;
using Microsoft.VisualBasic;
using System.Windows;

class HW4t1
{
    static void Main()
    {
        int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());     
        }

        int A = Input("Введите число А: ");
        int B = Input("Введите число B: ");
        int BasicCalc(int A, int B)
        {
            int GradeB = A;
            for (int i = B; i > 1; i--)
            {
                 GradeB *= A;
            }
            return GradeB;
        }
        Console.WriteLine($"{A}, {B} -> {BasicCalc(A, B)}");

    }
}

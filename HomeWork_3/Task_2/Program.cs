/*Задача 2 Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84 
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.Clear();

int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int[] dotA = new int[3];
int[] dotB = new int[3];

void FillArray(int[] dotA, int[] dotB)
{
    for (int i = 0; i < dotA.Length; i++)
    {
        dotA[i] = Prompt("Введите координату точкиA: ");
        dotB[i] = Prompt("Введите координату точкиB: ");
        /*dotA[i] = new Random().Next(-10, 10);
        dotB[i] = new Random().Next(-10, 10);*/
    }
}

void Mathematic(int[] ArrA, int[] ArrB)
{
    double Sum = 0;
    double Dist = 0;
    for (int i = 0; i < ArrA.Length; i++)
    {   
        double PowDiff = Math.Pow((ArrA[i] - ArrB[i]), 2);
        Sum += PowDiff;
        Console.WriteLine($"{PowDiff} : {Sum}");
    }
    Dist = Math.Sqrt(Sum);
    Console.WriteLine($"Dist_3D: {(int)Dist}");
}
FillArray(dotA, dotB);

Console.WriteLine();
PrintArray(dotB);
Console.WriteLine();
Mathematic(dotA, dotB);
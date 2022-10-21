/*Задача 2 Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84 
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.Clear();

int[] dotA = new int[3];
int[] dotB = new int[3];

void FillArray(int[] dotA, int[] dotB)
{
    int Prompt(string msg)
    {
        Console.WriteLine(msg);
        return int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < dotA.Length; i++)
    {
        dotA[i] = Prompt("Введите координату точкиA: ");
        dotB[i] = Prompt("Введите координату точкиB: ");
    }
}

void PrintArr(int[] ArrA)
{
    for (int i = 0; i < ArrA.Length; i++)
    {
        
        if (i == ArrA.Length - 1) Console.Write($"{ArrA[i]}");
        else Console.Write($"{ArrA[i]}, ");
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
    }
    Dist = Math.Sqrt(Sum);
    Console.Write($"Dist: {Dist:f2}");
}

FillArray(dotA, dotB);
Console.Write("A(");
PrintArr(dotA);
Console.Write(") ");
Console.Write("B(");
PrintArr(dotB);
Console.Write(") -> ");
Mathematic(dotA, dotB);
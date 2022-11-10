/*Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
class HW4t1
{
    static void Main()
    {
        double Input(string message)
        {
            Console.Write(message);
            return Convert.ToDouble(Console.ReadLine());     
        }

        double A = Input("Input A: ");
        double B = Input("Input B: ");       
            
        double Power(double A, double B)
        {
            double GradeB = A;
            if (B == 0) return GradeB = 1;
            else if (B > 1)
            {
                for (; B - 1 > 0; B--) GradeB *= A;
                return GradeB;
            }
            else if (B < 0) 
            {
                for(; B + 1 < 0; B++) GradeB *= A;
                return GradeB = 1 / GradeB;
            }
            return GradeB;
        }

        Console.WriteLine($"{A}, {B} -> {Power(A,B)}");
    }
}

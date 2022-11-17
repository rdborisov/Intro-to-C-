/*
Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
class H6T2
{
    public static void Main()
    {
        double Input(string message)
        {
            Console.Write(message);
            return double.Parse(Console.ReadLine());
        }

        double[] IntersectionPoint(double b1, double k1, double b2, double k2)
        {
            if (k1 == k2) return null;
            else
            {
                double x = (b2 - b1) / (k1 - k2);
                double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
                return new double[2] { x, y };
            }
        }
        void RecognitionIntersectionPoint(double b1, double k1, double b2, double k2)
        {
            if (IntersectionPoint(b1, k1, b2, k2) is not null)
            {
                double[] result = IntersectionPoint(b1, k1, b2, k2);
                Console.Write($"Точка пересечения (x,y): ({result[0]:f1}, {result[1]:f1})");
            }
            else Console.WriteLine("Прямые параллельны");
        }

        void Output()
        {
            double b1 = Input("Input b1: ");
            double k1 = Input("Input k1: ");
            double b2 = Input("Input b2: ");
            double k2 = Input("Input k2: ");
            RecognitionIntersectionPoint(b1, k1, b2, k2);
        }
        Output();

    }
}
// See https://aka.ms/new-console-template for more information

using System;

namespace Main
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 2. Программа для решение квадратных уравнений ax^2+ bx + c = 0\n\r");
            Console.WriteLine("Введите 'a':");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите 'b':");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите 'c':");
            double c = double.Parse(Console.ReadLine());

            double D = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("\n\rДискриминант:" + D);

            switch (D)
            {
                case < 0:
                    Console.WriteLine("В данном уровнении нет корней");
                    break;
                case 0:
                    Console.WriteLine("Данное уровнении содержит один корень:");
                    double x =( -1 * (b)) / (2 * a);
                    Console.WriteLine("х1,2 = " + x);
                    break;
                case > 0:
                    Console.WriteLine("Данное уровнении содержит два корня:");
                    double x11 = (-1 * (b) - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("х1 = " + x11);
                    double x12 = (-1 * (b) + Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("х2 = " + x12);
                    break;
            }

        }
    }
}
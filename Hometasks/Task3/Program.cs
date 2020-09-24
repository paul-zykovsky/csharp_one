using System;

/* Студент: Зыков Павел. ДЗ №3: программа "Расстояние между точками". 
 */
namespace Task3
{
    class Program
    {
        static int Main(string[] args)
        {
            double x1, y1, x2, y2, r;

            Console.Write("Введите координату \'x\' первой точки: ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату \'у\' первой точки: ");
            y1 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату \'x\' второй точки: ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату \'y\' второй точки: ");
            y2 = double.Parse(Console.ReadLine());

            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("a) Расстояние между точками: {0:f2}.", r);
            Console.WriteLine("б) Расстояние между точками: {0:f2}.", Distance(x1, y1, x2, y2));

            return 0;
        }

        static double Distance(double x1, double y1, double x2, double y2) 
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}

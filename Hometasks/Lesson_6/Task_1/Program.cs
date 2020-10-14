using System;

/* Студент: Зыков Павел, урок №6, задание №1, написание делегатов. */
namespace Task_1
{
    class Program
    {
        static double foo1(double a, double x)
        {
            return a * Math.Pow(x, 2);
        }

        static double foo2(double a, double x)
        {
            return a * Math.Sin(x);
        }

        public delegate double Function(double a, double x);

        static void PrintTable(Function func, double a, 
            double left, double right, double step)
        {
            for (double i = left; i <= right; i += step)
                Console.WriteLine($"{i} - {func(a, i)}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Function f1 = new Function(foo1), f2 = new Function(foo2);
            PrintTable(f1, 1.25, -5.0, 5.0, 1.0);
            PrintTable(f2, 1.25, -5.0, 5.0, 1.0);
        }
    }
}

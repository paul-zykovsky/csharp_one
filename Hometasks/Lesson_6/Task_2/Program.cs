using System;
using System.IO;
using System.Collections.Generic;

/* Студент: Зыков Павел, урок №6, задание №2, модификация ф-ции поиска минимума ф-ции.
 * а) создать список делегатов на возможные функции.
 * б) переделка  ф-ции Load(). */
namespace Task_2
{
    class Program
    {
        public static double f1(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double f2(double x)
        {
            return -x * Math.Sin(Math.Pow(x, 3));
        }

        public static double f3(double x)
        {
            return Math.Sqrt(Math.Abs(x));
        }

        public delegate double Function(double x);

        public static void SaveFunc(string fileName, Function func, double a, double b, double h)
        {
            StreamWriter fs = new StreamWriter(fileName);          
            double x = a;
            while (x <= b)
            {
                fs.WriteLine(func(x));
                x += h;
            }
            fs.Close();
        }

        public static List<double> Load(string fileName, out double min)
        {
            StreamReader fs = new StreamReader(fileName);
            List<double> result = new List<double>();
            double l_min = double.MaxValue;
            double d;
            while (!fs.EndOfStream)
            { 
                d = double.Parse(fs.ReadLine());
                result.Add(d);
                if (d < l_min) l_min = d;
            }
            fs.Close();
            min = l_min;
            return result;
        }

        static void Main(string[] args)
        {
            // Формируем список делегатов.
            List<Function> functions = new List<Function>() {f1, f2, f3 };
            double left, right, step;

            Console.WriteLine("Введите границы.");
            Console.Write("Левая: ");
            left = double.Parse(Console.ReadLine());
            Console.Write("Правая: ");
            right = double.Parse(Console.ReadLine());

            Console.Write("Введите шаг: ");
            step = double.Parse(Console.ReadLine());

            Console.WriteLine("№1 - f(x) = x * x - 50 * x + 10");
            Console.WriteLine("№2 - f(x) = -x * sin(x^3)");
            Console.WriteLine("№3 - f(x) = sqrt(abs(x))");
            Console.Write("Выберите функцию: ");
            switch (int.Parse(Console.ReadLine()))
            { 
                case 1:
                    SaveFunc("data.txt", functions[0], left, right, step);
                    break;
                case 2:
                    SaveFunc("data.txt", functions[1], left, right, step);
                    break;
                case 3:
                    SaveFunc("data.txt", functions[2], left, right, step);
                    break;
            }

            double min;
            Load("data.txt", out min);
            Console.WriteLine($"min = {min}");
            Console.ReadKey();
        }
    }
}


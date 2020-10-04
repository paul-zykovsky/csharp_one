using System;

/* Студент: Зыков Павел, занятие №3, задача 1, Модификация структуры/класса Complex.
 */
namespace Task_1
{
    struct Complex_struct
    {
        public double im, re;
        public Complex_struct Plus(Complex_struct x)
        {
            Complex_struct y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public Complex_struct Minus(Complex_struct x)
        {
            Complex_struct y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public Complex_struct Multiple(Complex_struct x)
        {
            Complex_struct y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }


    class Complex_class
    {
        private double im, re;

        public Complex_class() { im = re = 0; }

        public Complex_class(double re, double im)
        {     
            this.im = im;
            this.re = re;
        }
        public Complex_class Plus(Complex_class x2)
        {
            Complex_class x3 = new Complex_class();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        public Complex_class Minus(Complex_class x2)
        {
            Complex_class x3 = new Complex_class();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }

        public Complex_class Multiple(Complex_class x2)
        {
            Complex_class x3 = new Complex_class();
            x3.re = re * x2.re - im * x2.im;
            x3.im = im * x2.re + re * x2.im;
            return x3;
        }

        // Свойства - это механизм доступа к данным класса.
        public double Im
        {
            get { return im; }
            set
            {
                // Для примера ограничимся только положительными числами.
                if (value >= 0) im = value;
            }
        }
        
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Complex как структура ===");
            Complex_struct a, b;
            a.re = 7; a.im = 3;
            b.re = 2; b.im = 1;
            Console.WriteLine($"Сложение: {(a.Plus(b)).ToString()}");
            Console.WriteLine($"Вычитание: {(a.Minus(b)).ToString()}");
            Console.WriteLine($"Умножение: {(a.Multiple(b)).ToString()}");

            Console.WriteLine();

            Console.WriteLine("=== Complex как класс ===");
            Complex_class c = new Complex_class(7, 3), d = new Complex_class(2, 1);
            Console.WriteLine($"Сложение: {(c.Plus(d)).ToString()}");
            Console.WriteLine($"Вычитание: {(c.Minus(d)).ToString()}");
            Console.WriteLine($"Умножение: {(c.Multiple(d)).ToString()}");
        }
    }
}

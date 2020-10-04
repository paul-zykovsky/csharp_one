using System;

/* Студент: Зыков Павел, занятие №3, задача 3,  класс "Дробь".
 */
namespace Task_3
{
    class Fraction
    {
        private int    a;    // numerator;
        private int    b;    // denomerator;
        private double value;// double representation;

        public int A
        {
            get { return a; }
            set 
            { 
                a = value;
                this.value = (double)a / b;
            }
        }

        public int B
        {
            get { return b; }
            set
            {
                try
                {
                    b = value;
                    if (b == 0)
                        throw new ArgumentException("Знаменатель не может быть равен 0", "b");
                    this.value = (double)a / b;
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("{0}: {1}", e.GetType().Name, e.Message);
                }
            }
        }

        public double Value
        {
            get { return value; }
            private set { this.value = value; }
        }

        public Fraction() { a = 0; b = 1; value = 0.0; }

        public Fraction(int a, int b) { A = a; B = b; }

        public Fraction Plus(Fraction add)
        {
            Fraction result = new Fraction();
            result.b = b * add.b;
            result.a = add.a * b + a * add.b;
            return result;
        }

        public Fraction Minus(Fraction dec)
        {
            Fraction result = new Fraction();
            result.b = b * dec.b;
            result.a = a * dec.b - b * dec.a;
            return result;
        }

        public Fraction Multiple(Fraction with)
        {
            Fraction result = new Fraction();
            result.a = a * with.a;
            result.b = b * with.b;
            return result;
        }

        public Fraction Divide(Fraction onto)
        {
            Fraction result = new Fraction();
            result.a = a * onto.b;
            result.b = b * onto.a;
            return result;
        }

        public string toString() { return a + "/" + b; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(1, 3), b = new Fraction(1, 3);
            Console.WriteLine("Fraction A = 1/3, B = 1/3 ");
            Console.WriteLine($"A + B = {a.Plus(b).toString()}");
            Console.WriteLine($"A - B = {a.Minus(b).toString()}");
            Console.WriteLine($"A * B = {a.Multiple(b).toString()}");
            Console.WriteLine($"A : B = {a.Divide(b).toString()}");

            Console.WriteLine("C = 1/0");
            Fraction c = new Fraction(1, 0);
        }
    }
}

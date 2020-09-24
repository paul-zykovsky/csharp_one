using System;

/* Студент: Зыков Павел. ДЗ №2: программа "Индекс массы тела". 
 */
namespace Task2
{
    class Program
    {
        static int Main(string[] args)
        {
            string height, weight;
            double idx;
            
            Console.Write("Ваш рост: ");
            height = Console.ReadLine();
            Console.Write("Ваш вес: ");
            weight = Console.ReadLine();

            idx = double.Parse(weight) / Math.Pow(double.Parse(height), 2);
            Console.WriteLine("Индекс массы тела: {0:f5}.", idx);

            return 0;
        }
    }
}

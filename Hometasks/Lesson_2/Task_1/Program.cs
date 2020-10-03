using System;

/* Студент: Зыков Павел. Урок 2, задание 1, метод возвращает 
 * минимальное из трех чисел.
 */
namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine($"Min({a}, {b}, {c}): {Min(a, b, c)}");
        }

        static int Min(int a, int b, int c)
        {
            int min = (a < b) ? a : b;
            return (min < c) ? min : c;
        }
    }
}

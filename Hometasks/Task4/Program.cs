using System;

/* Студент: Зыков Павел. ДЗ №4: программа "Обмен значений переменных"
 * Подвариант б).
 */
namespace Task4
{
    class Program
    {
        static int Main(string[] args)
        {
            int a = 3, b = 5;

            Console.WriteLine($"a = {a}, b = {b}");
            a = a + b;
            b = b - a;
            b = -b;
            a = a - b;
            Console.WriteLine($"a = {a}, b = {b}");

            return 0;
        }
    }
}

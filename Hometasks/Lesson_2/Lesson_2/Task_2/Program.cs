using System;

/* Студент: Зыков Павел. Урок 2, задание 2, метод возвращает 
 * количество цифр числа.
 */
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Кол-во цифр числа {a} : {CntDigits(a)}");
        }

        static int CntDigits(int a)
        {
            int count = (a == 0)? 1 : 0;
            for (; a != 0; count++, a /= 10)
                ;
            return count;
        }
    }
}

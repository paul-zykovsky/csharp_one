using System;

/* Студент: Зыков Павел. Урок 2, задание 3, расчет суммы нечет. полож. чисел.
 */
namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, tmp;
            for (; (tmp = int.Parse(Console.ReadLine())) != 0;) {
                if (tmp % 2 == 1 && tmp > 0)
                    sum += tmp;
            }
            Console.WriteLine($"Результат: {sum}");
        }
    }
}

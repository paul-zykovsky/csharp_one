using System;

/* Студент: Зыков Павел. Урок 2, задание 6, подсчет времени выполнения программы.
 */
namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            DateTime start = DateTime.Now;
       
            for (int i = 1; i <= 10_000_000; i++)
                if (isGood(i))
                    count++;
            Console.WriteLine($"Кол-во хороших чисел: {count}");
            Console.WriteLine($"Время исполнения: {DateTime.Now - start}");
        }

        static bool isGood(int number) 
        {
            int sum = 0, copy_number = number;
            for (; number != 0; number /= 10)
                sum += number % 10;
            return (copy_number % sum == 0) ? true : false;
        }
    }
}

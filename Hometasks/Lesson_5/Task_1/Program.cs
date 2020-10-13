using System;
using System.Globalization;
using System.Text.RegularExpressions;

/* Студент Зыков Павел, урок №5, задание №1, проверка корректности логина.
   a) без использования регулярных выражений
   б) с использованием регулярных выражений.
*/
namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            const int A_up = 0x41, Z_up = 0x5A, a_low = 0x61, z_low = 0x7A;

            Console.Write("Введите логин: ");
            login = Console.ReadLine();

            Console.WriteLine("=== Вариант а) ===");
            if (2 <= login.Length && login.Length <= 10)
            {
                bool success = true;
                for (int i = 0; i < login.Length; i++)
                {
                    int tmp = (int)login[i];
                    if (!(
                        (char.IsDigit(login[i]) && i != 0) ||
                         (A_up <= tmp && tmp <= Z_up) ||
                         (a_low <= tmp && tmp <= z_low)
                         ))
                    {
                        Console.WriteLine("Логин синт.-ки неверен.");
                        success = false;
                        break;
                    }
                }
                if (success == true)
                    Console.WriteLine("Логин верен.");
            }
            else
            {
                Console.WriteLine("Длина логина некорректна.");
            }

            Console.WriteLine("=== Вариант б) ===");
            Regex pattern = new Regex(@"[\D,A-Z,a-z][\d,A-Z,a-z]{1,8}");
            Match match = pattern.Match(login);
            if (match.Success && match.ToString().Length == login.Length)
            {
                Console.WriteLine("Логин верен.");
            }
            else
            {
                Console.WriteLine("Логин неверен.");
            }

        }
    }
}

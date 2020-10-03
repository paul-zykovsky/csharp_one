using System;

/* Студент: Зыков Павел. Урок 2, задание 4, проверка логина и пароля.
 */
namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string login, passwd;
            int attempts = 0;
            do {
                login = Console.ReadLine();
                passwd = Console.ReadLine(); 
            } while ((login != "root" || passwd != "geekbrains") && ++attempts != 3);
            Console.WriteLine($"Access: {((attempts != 3)? true : false)}");
        }
    }
}

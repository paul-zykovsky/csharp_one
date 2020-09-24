using System;

/* Студент: Зыков Павел. ДЗ №1: программа "Анкета". 
 */
namespace Task1
{
    class Program
    {
        static int Main(string[] args)
        {
            string first_name, last_name, age, height, weight;

            Console.Write("Ваше имя: ");
            first_name = Console.ReadLine();
            Console.Write("Ваша фамилия: ");
            last_name = Console.ReadLine();
            Console.Write("Ваш возраст: ");
            age = Console.ReadLine();
            Console.Write("Ваш рост: ");
            height = Console.ReadLine();
            Console.Write("Ваш вес: ");
            weight = Console.ReadLine();

            Console.WriteLine(first_name + " " + last_name + 
                              ", возраст: " + age + ", рост: "
                              + height + ", вес: " + weight);
            Console.WriteLine("{0} {1}, возраст: {2}, рост: {3}, вес: {4}",
                              first_name, last_name, age, height, weight);
            Console.WriteLine($"{first_name} {last_name}, возраст: {age}, рост: {height}, вес: {weight}");

            return 0;
        }
    }
}

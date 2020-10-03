using System;

/* Студент: Зыков Павел. Урок 2, задание 5, проверка ИМТ.
 */
namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight, height, weight_norm;
            double idx, sqr_height;

            weight = int.Parse(Console.ReadLine());
            height = int.Parse(Console.ReadLine());
            sqr_height = Math.Pow(height / 100.0, 2);
            idx = weight / sqr_height;
            Console.WriteLine($"Индекс: {idx}");

            if (idx < 18.5)
            {
                weight_norm = (int)(18.5 * sqr_height);
                Console.WriteLine($"Наберите {weight_norm - weight} кг");
            }
            else if (idx <= 25)
            {
                Console.WriteLine("Вес в норме");
            }
            else {
                weight_norm = (int)(25 * sqr_height);
                Console.WriteLine($"Сбросьте {weight - weight_norm} кг");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

/* Студент Зыков Павел, урок №5, задание №2, статичный класс Message для операций над сообщениями.
*/
namespace Task_2
{
    class Message
    {
        /// <summary>
        /// Выводит на каждой строке слово, в котором 1..n символов.
        /// </summary>
        /// <param name="msg">Сообщение</param>
        /// <param name="n">Длина слова</param>
        public static void Print(string msg, int n)
        {
            Regex pattern = new Regex(@"\b\w{1," + n + @"}\b");
            MatchCollection good_words = pattern.Matches(msg);
            foreach (var word in good_words)
                Console.WriteLine(word.ToString());
        }

        /// <summary>
        /// Удаляет из сообщения слова, которые заканчиваются на определенный символ.
        /// </summary>
        /// <param name="msg">Сообщение</param>
        /// <param name="c">Символ конца слова</param>
        public static string Remove(string msg, char c)
        {
            Regex pattern = new Regex(@"\b(\S+)" + c + @"\b");
            return pattern.Replace(msg, "");
        }

        /// <summary>
        /// Поиск слов макимальной длины.
        /// </summary>
        /// <param name="msg">Строка сообщения</param>
        /// <param name="dim">Действительная размерность выходного массива строк, остальные элементы - мусор</param>
        /// <returns></returns>
        public static string[] Max(string msg, ref int dim)
        {
            Regex pattern = new Regex(@"\b(\w+)\b");
            MatchCollection all_words = pattern.Matches(msg);
            string[] max_words = new string[all_words.Count];
            int max_length = 0, max_count = 0;

            foreach (var word in all_words)
            {
                int current_length = word.ToString().Length;
                if (current_length > max_length)
                {
                    max_length = current_length;
                    max_words[0] = word.ToString();
                    max_count = 1;
                }
                else if (current_length == max_length)
                {
                    max_words[max_count++] = word.ToString();
                }
            }

            dim = max_count;
            return max_words;
        }

        /// <summary>
        /// Формирует изменяемую строку из максимальных строк.
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static StringBuilder StringFromMax(string msg)
        {
            int size = 0;
            string[] words = Max(msg, ref size);
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < size; i++)
                result.Append(words[i] + " ");

            return result;
        }

        /// <summary>
        /// Частотынй анализ текста по словам из словаря.
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="text"></param>
        public static void FreqAnalyze(ref Dictionary<string, int> dict, string text)
        {
            // Создаем копию ключей, т.к. при переборе циклом словарь read-only.
            var keys = new List<string>(dict.Keys); 

            foreach (var key in keys)
            {
                Regex pattern = new Regex(@"\b" + key + @"\b");
                dict[key] = pattern.Matches(text).Count;
            }           
        }
    }
}

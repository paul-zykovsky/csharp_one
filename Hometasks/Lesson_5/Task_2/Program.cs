using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>(3);
            string text = "Ехал Грека через реку, видит Грека в реке рак, сунул Грека руку в реку.";

            dict.Add("Грека", 0);
            dict.Add("реку", 0);
            dict.Add("рак", 0);
            Message.FreqAnalyze(ref dict, text);
            foreach (var word in dict)
                Console.WriteLine($"{word.Key} - {word.Value}");

        }
    }
}

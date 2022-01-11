using System;

namespace Nauka
{
    class Program
    {
        static void Main(string[] args)
        {
            test("Ala ma kota.", "kota ma Ala.");
            test("Ala ma kota", "kota ma Ala.");
        }

        static void test(string input, string expected)
        {
            bool result = ReverseWordsInSentence(input).Equals(expected);
            Console.WriteLine($"{result} Reverse string: {ReverseWordsInSentence(input)}");
        }

        static string ReverseWordsInSentence(string s)
        {
            if (s.EndsWith(".")) {
                s = s.Remove(s.Length - 1);
            }
            string[] words = s.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words) + ".";



        }

    }

}

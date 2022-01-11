using System;

namespace Nauka
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string s = "Ala ma kota.";


            Console.WriteLine($"Reverse string: {ReverseWordsInSentence(s)}");
        }


        static string ReverseWordsInSentence(string s)
        {

            s = s.Remove(s.Length - 1);
            string[] words = s.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words) + ".";



        }

    }

}

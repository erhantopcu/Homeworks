using System;

namespace FirstHomework_v_4
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter a sentence!");
            string sentence = Console.ReadLine();

            Console.WriteLine("Word numbers in sentence");
            Console.WriteLine(sentence.spaceCounter());

            Console.WriteLine("Number of letters in a sentence: ");
            sentence = sentence.RemoveWhiteSpaces();
            Console.WriteLine(sentence.CharCounter());
        }
    }
    public static class Extension
    {
        public static int spaceCounter(this string param)
        {
            int whiteSpaceCounter = 0;

            foreach (char item in param)
            {
                if (item == ' ')
                {
                    whiteSpaceCounter++;
                }

            }
            return whiteSpaceCounter + 1;
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }
        public static int CharCounter(this string param)
        {
            int charCount = 0;
            foreach (int charNum in param)
            {
                charCount++;
            }
            return charCount;
        }
    }
}



using System;

namespace FirstHomework_v_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the positive n number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter " + n + " numbers which is your words");

            string[] word = new string[n];

            for (int i = 1; i <= word.Length; i++)
            {
                Console.WriteLine(i + ". word: ");
                word[i-1] = Console.ReadLine();
                
            }
            Array.Reverse(word);
            Console.WriteLine("This is the bottom to top list of the entered words");

            foreach (string item in word)
            {
                    Console.WriteLine(item + " ");
                
            }
        }
    }
}

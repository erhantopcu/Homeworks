using System;

namespace FirstHomework_v_2
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Please enter n numbers");
            int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter m which is your dividing number");
            int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is your n numbers?");
            
            int[] numbers = new int[n];

            for(int i = 1; i <= numbers.Length; i++)
            {
                 Console.Write(i + ". number: ");
                 numbers[i-1] = Convert.ToInt32(Console.ReadLine());
            }
        Console.WriteLine("Numbers divisible by or equal to the second number entered first: ");
                    foreach(var item in numbers)
                    {
                      if(item % m == 0 || item == m)
                      
                        Console.Write(" " + item);

                      else

                        Console.WriteLine("Your numbers are not exactly divisible.");
                      
                    }
        }
    }
}
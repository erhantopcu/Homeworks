using System;

namespace FirstHomework
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Specify how many numbers.");  //
           int a = Convert.ToInt32(Console.ReadLine());
           int[] numbers = new int[a]; 
           
           
           for(int i = 0; i < numbers.Length; i++)
           {
                    Console.WriteLine("Please enter the a positive number: ");
                    numbers[i] = int.Parse(Console.ReadLine());
           }

           Array.Sort(numbers);
           foreach (var item in numbers)
           Console.Write(item + " ");
           Console.WriteLine(" ");
           Console.WriteLine("**Here is your even number results**");
           
           for(int i =0; i < numbers.Length; i++)
           {
                if(numbers[i]%2==0)
                    
                    Console.Write(numbers[i] + " "); 

           
                else

                     Console.WriteLine("There is no even number.");
            }        
        }
    }
}

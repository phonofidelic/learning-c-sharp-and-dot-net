using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawInput = Console.ReadLine() ?? "";

            if (rawInput == "")
            {
                Console.WriteLine("No input. Exiting...");
                return;
            }
            
            string[] inputStringArray = rawInput.Split(" ");
            
            int fizzDivider = Int32.Parse(inputStringArray[0]);
            int buzzDivider = Int32.Parse(inputStringArray[1]);
            int length = Int32.Parse(inputStringArray[^1]);


            for (int i = 1; i <= length; i++)
            {
                string result = "";

                if (i % fizzDivider == 0)
                {
                    result += "Fizz";
                }

                if (i % buzzDivider == 0)
                {
                    result += "Buzz";
                }

                if (result == "")
                {
                    Console.WriteLine(i);
                    continue;
                }

                Console.WriteLine(result);
            }
        }
                
    }
}
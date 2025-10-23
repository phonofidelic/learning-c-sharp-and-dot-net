using System;

/* 
https://open.kattis.com/problems/99problems

Ingrid is the founder of a company that sells bicycle parts. 
She used to set the prices of products quite arbitrarily, 
but now she has decided that it would be more profitable if 
the prices end in 99.

You are given a positive integer N, the price of a product. 
Your task is to find the nearest positive integer to N which ends in 99. 
If there are two such numbers that are equally close, find the bigger one.

Input
The input contains one integer N (1 ≤ N ≤ 10000), the price of a product. 
It is guaranteed that the number N does not end in 99.

Output
Print one integer, the closest positive integer that ends in 99. 
In case of a tie, print the bigger one.
*/
namespace NinetyNineProblems
{
    class Program
    {
        static string ConvertPrice(string rawInput)
        {
            int inputPrice = Int32.Parse(rawInput);
            /* 
                If the input price is less than 3 digits, we can return "99" early 
            */
            if (inputPrice < 100)
            {
                return "99";
            }

            /* 
                Set a tipping point so that if the difference between converted price 
                and input price is grater than 50, decrease the start of the price by 1
            */
            int cutoffIndex = rawInput.Length - 2;
            string start = rawInput[..cutoffIndex];
            int convertedPrice = Int32.Parse(start + "99");

            if ((convertedPrice - inputPrice) > 50)
            {
                int startInt = Int32.Parse(start);
                startInt -= 1;
                start = startInt > 0 ? startInt.ToString() : "";
            }

            return start + "99";
        }

        static void Main(string[] args)
        {

            string rawInput = Console.ReadLine() ?? "";

            if (rawInput == "")
            {
                Console.WriteLine("No input. Exiting...");
                return;
            }

            string convertedPrice = ConvertPrice(rawInput);

            Console.WriteLine(convertedPrice);
        }
    }
}

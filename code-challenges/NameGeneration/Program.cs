using System;

/*
https://open.kattis.com/problems/namegeneration
Ingrid is the founder and CEO of bicycle retailer BIKEA. 
The company sells bicycles for customers to assemble themselves.

BIKEA has N different bicycles to offer. Ingrid wants to give 
each of them a human-readable name, to make it easy to remember. 
But doing this by hand is a very time consuming task.

You are given the number N, and your task is to generate N different names. 
To make the names readable, they must satisfy the following:

1. Each name has length between 3 and 20, 
and only consists of lowercase English letters.

2. Three consecutive letters of a name cannot all be vowels 
or consonants. Here we consider a, e, i, o, u vowels, while 
the remaining 21 letters are consonants.

For example, 'hello', 'bar', and 'lkab' are all valid names, 
whereas 'ingrid', 'bo and 'louise' are invalid.

## Input
The input consists of one integer N (1 ≤ N ≤ 30000), 
the number of names to generate.

## Output
Print N lines, each of them containing a name. 
It can be proven that it is possible to generate N different names.

## Sample input:
3

## Sample output:
abdullah
bjorn
nils
*/
namespace NameGeneration
{
    class Program
    {

        static List<string> GenerateNames(int amount)
        {
            List<string> names = [];

            for (int i = 0; i < amount; i++)
            {
                names.Add("Name " + (i + 1));
            }

            return names;
        }
        static void Main(string[] args)
        {
            string rawInput = Console.ReadLine() ?? "0";
            int namesAmount = int.Parse(rawInput);
            if (namesAmount < 1)
            {
                Console.WriteLine("No names to create. Exiting...");
                return;
            }

            List<string> generatedNamed = GenerateNames(namesAmount);
            foreach (string name in generatedNamed)
            {
                Console.WriteLine(name);
            }
        }
    }
}
// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

namespace BoxAndArrowDiagram
{
    class Program
    {
        static string SAMPLE_INPUT =
@"3 4
1 2
2 3
1 2
3 3
7
2 2
2 3
1 4
2 3
1 1
1 3
2 3";

        static void Main(string[] args)
        {
            List<string> lines = SAMPLE_INPUT.Split("\n").ToList();
            string[] firstLinePair = lines[0].Split(" ");
            int boxAmount = int.Parse(firstLinePair[0]);
            int arrowAmount = int.Parse(firstLinePair[1]);
            List<string> arrows = lines[1..(arrowAmount + 1)];
            int queriesAmount = int.Parse(lines[arrowAmount + 1]);
            List<string> queries = lines[(arrowAmount + 2)..];

            Console.WriteLine($"Boxes amount: {boxAmount}");
            Console.WriteLine($"Arrows amount:{arrowAmount}");
            Console.WriteLine("Arrows:");
            foreach (string arrow in arrows)
            {
                Console.WriteLine($"\t{arrow}");
            }
            Console.WriteLine($"Queries amount: {queriesAmount}");
            foreach (string query in queries)
            {
                Console.WriteLine($"\t{query}");
            }
        }
    }

    class Box
    {

    }

    class Arrow
    {

    }
    
    class Query
    {
        
    }
}
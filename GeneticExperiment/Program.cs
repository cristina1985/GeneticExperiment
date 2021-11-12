using System;
using System.Collections.Generic;

namespace GeneticExperiment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide the input compounds in format string:");
            string s = Console.ReadLine();
            //Console.WriteLine($"The value of s is {s}");
            //Console.ReadLine();
            var charFrequencies = new Dictionary<char, int>();
            foreach (char c in s)
            {
                int count = 1;
                if (charFrequencies.ContainsKey(c))
                    count = charFrequencies[c] + 1;
                charFrequencies[c] = count;
                
            }

            Console.WriteLine("The result of compound synthesis is :");
            foreach (var pair in charFrequencies)
            {
                Console.Write("{0}{1}",pair.Key, pair.Value);
            }

            Console.ReadLine();
        }
    }
}

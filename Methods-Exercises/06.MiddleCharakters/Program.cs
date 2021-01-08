﻿using System;

namespace _06.MiddleCharakters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            if(input.Length % 2 == 0)
            {
                string output = GetMiddleCharFromEvenStringLenght(input);
                Console.WriteLine(output);
            }
            else
            {
                string oddOutput = GetMiddleCharFromOddStringLenght(input);
                Console.WriteLine(oddOutput);
            }
        }

        private static string GetMiddleCharFromOddStringLenght(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index, 1);
            return chars;
        }

        private static string GetMiddleCharFromEvenStringLenght(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index - 1, 2);
            return chars;
        }
    }
}

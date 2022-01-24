using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Dictionary<char, int> symbols = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                int count = 1;
                char currChar = input[i];

                if (symbols.ContainsKey(currChar))
                {
                    symbols[currChar]++;
                }
                else
                {
                    symbols.Add(currChar, count);
                }


            }
            Dictionary<char, int> upperCase = new Dictionary<char, int>();
            Dictionary<char, int> lowerCase = new Dictionary<char, int>();
            Dictionary<char, int> symbolsKey = new Dictionary<char, int>();
            foreach (var item in symbols)
            {
                if (char.IsUpper(item.Key))
                {
                    upperCase.Add(item.Key, item.Value);
                }
                else if (char.IsLower(item.Key))
                {
                    lowerCase.Add(item.Key, item.Value);
                }
                else
                {
                    symbolsKey.Add(item.Key, item.Value);
                }
            }
            upperCase = upperCase.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            lowerCase = lowerCase.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            symbolsKey = symbolsKey.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in symbolsKey)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
            foreach (var item in upperCase)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
            foreach (var item in lowerCase)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace _3._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> elements = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                foreach (var item in input)
                {
                    elements.Add(item);
                }
            }
            List<string> newElements = new List<string>();
            foreach (var element in elements)
            {
                newElements.Add(element);
            }
            newElements.Sort();
            Console.WriteLine(String.Join(" ", newElements));
        }
    }
}

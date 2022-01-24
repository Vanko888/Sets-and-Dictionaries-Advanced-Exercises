using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> nNumbers = new HashSet<int>();
            HashSet<int> mNumbers = new HashSet<int>();
            int n = nums[0];
            int m = nums[1];
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                nNumbers.Add(input);
            }
            for (int j = 0; j < m; j++)
            {
                int input = int.Parse(Console.ReadLine());
                mNumbers.Add(input);
            }
            foreach (var item in nNumbers)
            {
                if (mNumbers.Contains(item))
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}

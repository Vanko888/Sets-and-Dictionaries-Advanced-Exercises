using System;
using System.Collections.Generic;

namespace _4._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            int currNum = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }
            int count = 1;
            for (int i = 0; i < numbers.Count; i++)
            {
                currNum = numbers[i];
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (currNum == numbers[j] && j != i)
                    {
                        count++;

                    }
                }
                if (count % 2 == 0)
                {
                    Console.WriteLine(currNum);
                    return;
                }
            }
        }
    }
}

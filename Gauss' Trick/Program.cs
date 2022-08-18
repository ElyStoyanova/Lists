using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> gaussNumbers = new List<int>();

            for (int i = 0; i <inputNumbers.Count/2; i++)
            {
              int cuurentGaussNumbers = inputNumbers[i] + inputNumbers[(inputNumbers.Count - 1)-i];
                gaussNumbers.Add(cuurentGaussNumbers);
            }
            if (inputNumbers.Count %2!=0)
            {
                gaussNumbers.Add(inputNumbers[inputNumbers.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", gaussNumbers));

        }
    }
}

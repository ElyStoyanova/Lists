using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> name = Console.ReadLine().Split(" ").Select(int.Parse).ToList();


            var maxMin = name.Max(x => x * x);

            Console.WriteLine(string.Join(" ",name));
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(firstList.Count,secondList.Count); i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }
            if (firstList.Count>secondList.Count)
            {
                result.AddRange(GetRemainingElements(firstList, secondList));
            }
            else if (secondList.Count>firstList.Count)
            {
                result.AddRange(GetRemainingElements(secondList,firstList));
            }
            Console.WriteLine(string.Join(" ",result));
        }

        static IEnumerable<int> GetRemainingElements(List<int> longestList, List<int> shortList)
        {
            List<int> nums = new List<int>();

            for (int i = shortList.Count; i < longestList.Count; i++)
            {
                nums.Add(longestList[i]);
            }
            return nums;
        }
    }
}

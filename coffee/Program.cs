using System;
using System.Collections.Generic;
using System.Linq;

namespace Memory_game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coffeeList = Console.ReadLine().Split().ToList();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string command = Console.ReadLine();
                string[] tokans = command.Split();

                switch (tokans[0])
                {
                    case "Include":
                        coffeeList.Add(tokans[1]);
                        break;
                    case "Remove":
                        int numberOfCoffees = int.Parse(tokans[2]);
                        if (numberOfCoffees <= coffeeList.Count)
                        {
                            switch (tokans[1])
                            {
                                case "first":
                                    coffeeList.RemoveRange(0, numberOfCoffees);
                                    break;
                                case "last":
                                    coffeeList.RemoveRange(coffeeList.Count - numberOfCoffees, numberOfCoffees);
                                    break;
                            }
                        }
                        break;
                    case "Prefer":
                        int coffeIndex1 = int.Parse(tokans[1]);
                        int coffeIndex2 = int.Parse(tokans[2]);

                        if ((coffeIndex1 < coffeeList.Count - 1) && (coffeIndex2 < coffeeList.Count - 1))
                        {
                            string swap = coffeeList[coffeIndex1];
                            coffeeList[coffeIndex1] = coffeeList[coffeIndex2];
                            coffeeList[coffeIndex2] = swap;

                        }
                        break;
                    case "Reverse":
                        coffeeList.Reverse();
                        break;
                }
            }
            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", coffeeList));
        }
    }
}

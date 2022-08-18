using System;
using System.Collections.Generic;
using System.Linq;

namespace Train_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string inputCommand = Console.ReadLine();

            while (inputCommand != "end")
            {
                string[] inputArr = inputCommand.Split();

                if (inputArr[0] == "Add")
                {
                    int passengersNextWagon = int.Parse(inputArr[1]);
                    wagons.Add(passengersNextWagon);
                }
                else
                {
                    int passangers = int.Parse(inputArr[0]);
                    FindWagon(wagons,maxCapacity,passangers);
                }
                inputCommand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",wagons));
        }

        static void FindWagon(List<int> wagons, int maxCapacity, int passangers)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                int cuurentWagon = wagons[i];

                if (cuurentWagon+passangers<=maxCapacity)
                {
                    wagons[i] += passangers;
                    break;
                }
            }
        }
    }
}

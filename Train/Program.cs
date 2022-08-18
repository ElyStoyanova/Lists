using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string inputCommand = Console.ReadLine();

            while (inputCommand!="end")
            {
                string[] inputArr = inputCommand.Split();

                if (inputArr[0]=="Add")
                {
                    int passengersNextWagon = int.Parse(inputArr[1]);
                    wagons.Add(passengersNextWagon);
                }
                else
                {
                    int passengers = int.Parse(inputArr[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i]<maxCapacity)
                        {
                            int restCapasytyWagon = maxCapacity - wagons[i];

                            if (restCapasytyWagon>=passengers)
                            {
                                wagons[i]+=passengers ;
                                passengers = 0;
                            }
                            else
                            {
                                wagons[i]=maxCapacity;
                                passengers -= restCapasytyWagon;
                            }
                        }
                    }
                }
                inputCommand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}

using System;
using System.Linq;

namespace _Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            int houseIndex = 0;
            int sum = 0;
            int countHouses = 0;

            while (command!="Love!")
            {
                string[] tokans = command.Split();
                int jump = int.Parse(tokans[1]);

                houseIndex += jump;

                if (houseIndex>=neighborhood.Length)
                {
                    houseIndex = 0;
                }
                if (neighborhood[houseIndex] == 0)
                {
                    Console.WriteLine($"Place {houseIndex} already had Valentine's day.");
                }
                else
                {
                    neighborhood[houseIndex] -= 2;

                    if (neighborhood[houseIndex] == 0)
                    {
                        Console.WriteLine($"Place {houseIndex} has Valentine's day.");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {houseIndex}.");

            foreach (var number in neighborhood)
            {
                sum += number;

                if( number!=0)
                {
                    countHouses++;
                }
            }
            if (sum==0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {countHouses} places.");
            }

            
        }
    }
}

using System;
using System.Collections.Generic;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guestlist = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                var command = Console.ReadLine().Split();
                string cuurentName = command[0];

                if (guestlist.Contains(cuurentName)&&command[2]=="going")
                {
                    Console.WriteLine($"{cuurentName} is already in the list!");
                }
                else if (!guestlist.Contains(cuurentName) && command[2] == "not")
                {
                    Console.WriteLine($"{cuurentName} is not in the list!");
                }
                else if (guestlist.Contains(cuurentName) && command[2] == "not")
                {
                    guestlist.Remove(cuurentName);
                }
                else
                {
                    guestlist.Add(cuurentName);
                }
            }
            Console.WriteLine(string.Join("\n",guestlist));
        }
    }
}

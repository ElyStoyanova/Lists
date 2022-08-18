using System;
using System.Collections.Generic;
using System.Linq;

namespace Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targetArr = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command!="End")
            {
                string[] tokans = command.Split();
                int index = int.Parse(tokans[1]);
                int points = int.Parse(tokans[2]);


                switch (tokans[0])
                {
                    case "Shoot": ShootManipulating(index,points,targetArr);
                        break;
                    case "Add": AddManipulaiting(index, points, targetArr);
                        break;
                    case "Strike": StrikeManipulation(index, points, targetArr);
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|",targetArr));
        }

         static void StrikeManipulation(int index, int radius, List<int> targetArr)
        {
            if (index - radius < 0 || index + radius > targetArr.Count-1)
            {
                
                Console.WriteLine("Strike missed!");
                return;
            }
                targetArr.RemoveRange(index-radius, radius * 2 + 1);
        }

         static void AddManipulaiting(int index, int value, List<int> targetArr)
        {
            if (index<0 || index>targetArr.Count-1)
            {
                Console.WriteLine("Invalid placement!");
                return;
            }
            targetArr.Insert(index, value);
        }

         static void ShootManipulating(int index, int power, List<int> targetArr)
        {
            if (index<0 || index>targetArr.Count-1)
            {
                return;
            }
            targetArr[index] -= power;

            if (targetArr[index]<=0)
            {
                targetArr.RemoveAt(index);
            }
        }
    }
}

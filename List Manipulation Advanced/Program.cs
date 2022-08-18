using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split(); //convert string to array
                string action = tokens[0];

                switch (action)
                {
                    case "Contains":
                        int findNumber = int.Parse(tokens[1]);

                        if (numbers.Contains(findNumber))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i]%2==0)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        int sum = 0;

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        int number = int.Parse(tokens[2]);
                        string condition = tokens[1];
                        PrintFilter(numbers,condition, number);
                        break;

                }
            }
        }

         static void PrintFilter(List<int> numbers, string condition, int number)
        {
            switch (condition)
            {
                case "<":

                    foreach (var item in numbers)
                    {
                        if (item<number)
                        {
                            Console.Write(item);
                        }
                    }

                    Console.WriteLine();
                    break;
                case ">":

                    foreach (var item in numbers)
                    {
                        if (item > number)
                        {
                            Console.Write(item);
                        }
                    }

                    Console.WriteLine();
                    break;
                case ">=":

                    foreach (var item in numbers)
                    {
                        if (item >= number)
                        {
                            Console.Write(item);
                        }
                    }

                    Console.WriteLine();
                    break;
                case "<=":

                    foreach (var item in numbers)
                    {
                        if (item <= number)
                        {
                            Console.Write(item);
                        }
                    }

                    Console.WriteLine();
                    break;
            }
            
                
            
        }
    }
}

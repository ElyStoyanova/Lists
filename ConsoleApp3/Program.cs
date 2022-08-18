using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppinglist = Console.ReadLine().Split("!").ToList();
            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] tokens = command.Split();
                bool isElemementExist = shoppinglist.Contains(tokens[1]);

                switch (tokens[0])
                {
                    case "Urgent":
                        if (!isElemementExist)
                        {
                            shoppinglist.Insert(0, tokens[1]);
                        }
                        break;
                    case "Correct":
                        if (isElemementExist)
                        {
                            int index = shoppinglist.FindIndex(s => s == tokens[1]);

                            if (index != -1)
                            {
                                shoppinglist[index] = tokens[2];
                            }
                        }
                        break;
                    case "Unnecessary":
                        if (isElemementExist)
                        {
                            shoppinglist.Remove(tokens[1]);
                        }
                        break;
                    case "Rearrange":
                        if (isElemementExist)
                        {
                            shoppinglist.Remove(tokens[1]);
                            shoppinglist.Add(tokens[1]);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", shoppinglist));
        }
    }
}

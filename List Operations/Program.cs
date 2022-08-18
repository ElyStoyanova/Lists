using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command!="End")
            {
                string[] tokens = command.Split();
             
                switch (tokens[0])
                {
                    case "Add":
                        int element = int.Parse(tokens[1]);
                        inputNumbers.Add(element);
                        break;
                    case "Insert":
                        int indexInsert = int.Parse(tokens[2]);
                        int elementInsert = int.Parse(tokens[1]);
                        
                        if (indexInsert<0 ||indexInsert>inputNumbers.Count-1)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        inputNumbers.Insert(indexInsert, elementInsert);
                        break;
                    case "Remove":
                        int indexRemove = int.Parse(tokens[1]);

                        if (indexRemove < 0 || indexRemove > inputNumbers.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        inputNumbers.RemoveAt(indexRemove);
                        break;
                    case "Shift":
                        switch (tokens[1])
                        {
                            case "left":
                                int countLeft = int.Parse(tokens[2]);

                                for (int i = 0; i < countLeft; i++)
                                {
                                    inputNumbers.Add(inputNumbers[0]);
                                    inputNumbers.RemoveAt(0);
                                }
                                break;
                            case "right":
                                int countRight = int.Parse(tokens[2]);

                                for (int i = 0; i < countRight; i++)
                                {
                                    inputNumbers.Insert(0,inputNumbers[inputNumbers.Count-1]);
                                    inputNumbers.RemoveAt(inputNumbers.Count-1);
                                }
                                break;
                        }
                        break;      
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",inputNumbers));
        }
    }
}

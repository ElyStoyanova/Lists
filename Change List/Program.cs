using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputArr = Console.ReadLine().Split().Select(int.Parse).ToList();
            string coomand = Console.ReadLine();

            while (coomand!="end")
            {
                string[] tokens = coomand.Split();
                    
                switch (tokens[0])
                {
                    case "Delete":
                        int elementToDelete = int.Parse(tokens[1]);
                        inputArr.RemoveAll(el => el == elementToDelete);
                        break;
                    case "Insert":
                        int elementToinsert = int.Parse(tokens[1]);
                        int index = int.Parse(tokens[2]);
                        inputArr.Insert(index, elementToinsert);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ",inputArr));
        }
    }
}

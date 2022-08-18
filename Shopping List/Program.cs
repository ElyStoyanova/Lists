using System;
using System.Collections.Generic;

namespace Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfStrings = new List<string> { "abc", "123", "ghi" };

            int index = listOfStrings.FindIndex(s => s == "123");

            if (index != -1)
                listOfStrings[index] = "def";





            Console.WriteLine(string.Join(", ", listOfStrings));
        }
    }
}

using System;
using System.Collections.Generic;

namespace exx3
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<string> chat = new List<string>();

            while (command!="end")
            {
                string[] tokans = command.Split();

                switch (tokans[0])
                {
                    case "Chat":
                        chat.Add(tokans[1]);
                        break;
                    case "Delete":
                        if (chat.Contains(tokans[1]))
                        {
                            chat.Remove(tokans[1]);
                        } 
                        break;
                    case "Edit":
                            int index = chat.FindIndex(s => s == tokans[1]);
                        if (index!=-1)
                        {
                            chat[index] = tokans[2];
                        }
                        
                        break;
                    case "Pin":
                        int index1 = chat.FindIndex(s => s == tokans[1]);
                        if (index1 != -1)
                        {
                            chat.Add(tokans[1]);
                            chat.RemoveAt(index1);
                        }
                        break;
                    case "Spam":
                        for (int i = 1; i < tokans.Length; i++)
                        {
                            chat.Add(tokans[i]);
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join("\n",chat));
        }
    }
}

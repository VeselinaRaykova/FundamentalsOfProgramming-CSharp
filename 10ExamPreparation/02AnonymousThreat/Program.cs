using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02AnonymousThreat
{
    class Program
    {

        private static List<string> items;
        static void Main(string[] args)
        {
            items = Console.ReadLine().Split(' ').ToList();
            string[] input = Console.ReadLine().Split(' ').ToArray();

            while (input[0] != "3:1")
            {
                string command = input[0];
                if (command == "merge")
                {
                    int startIndex = int.Parse(input[1]);
                    int endIndex = int.Parse(input[2]);

                    Merge(startIndex, endIndex);
                }
                if (command == "divide")
                {
                    int index = int.Parse(input[1]);
                    int partitions = int.Parse(input[2]);

                    Divide(index, partitions);
                }

                input = Console.ReadLine().Split(' ').ToArray();
            }

            Console.WriteLine(string.Join(" ", items));
        }

        private static void Divide(int index, int partitions)
        {
            if (index < 0 || index > items.Count)
            {
                return;
            }

            string itemToDivide = items[index];
            if (itemToDivide.Length % partitions == 0)
            {
                DivideEqual(index, partitions, itemToDivide);
            }
            else
            {
                DivideNotEqual(index, partitions, itemToDivide);
            }
        }

        private static void DivideEqual(int index, int partitions, string itemToDivide)
        {
            List<string> dividedItems = new List<string>();
            int partitionLenght = itemToDivide.Length / partitions;

            for (int i = 0; i < itemToDivide.Length; i += partitionLenght)
            {
                string temp = itemToDivide.Substring(i, partitionLenght);
                dividedItems.Add(temp);
            }

            items.RemoveAt(index);
            items.InsertRange(index, dividedItems);
        }

        private static void DivideNotEqual(int index, int partitions, string itemToDivide)
        {
            List<char> temp = itemToDivide.ToCharArray().ToList();
            List<string> result = new List<string>();
            int partitionLenght = (int)(itemToDivide.Length / partitions);

            for (int i = 0; i < partitions - 1; i++)
            {
                StringBuilder sb = new StringBuilder();

                for (int j = 0; j < partitionLenght; j++)
                {
                    sb.Append(temp[j]);
                }
                result.Add(sb.ToString());
                temp.RemoveRange(0, partitionLenght);
            }

            result.Add(string.Join("", temp));
            items.InsertRange(index, result);
            items.RemoveAt(index + partitions);
        }

        private static void Merge(int startIndex, int endIndex)
        {
            startIndex = startIndex < 0 ? 0 : startIndex;
            startIndex = startIndex > items.Count - 1 ? 0 : startIndex;
            endIndex = endIndex > items.Count - 1 ? items.Count - 1 : endIndex;
            string mergedItem = "";

            for (int i = startIndex; i <= endIndex; i++)
            {
                mergedItem += items[i];
            }

            items.Insert(startIndex, mergedItem);
            int range = endIndex - startIndex + 1;
            items.RemoveRange(startIndex + 1, range);

        }
    }
}

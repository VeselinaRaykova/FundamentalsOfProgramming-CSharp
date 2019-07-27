using System;
using System.Collections.Generic;
using System.Linq;

namespace _03AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, DataSet> sets = new Dictionary<string, DataSet>();
            Dictionary<string, DataSet> cache = new Dictionary<string, DataSet>();

            while (true)
            {
                string[] inputData = Console.ReadLine().Split(new[] { " -> ", " | " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (inputData[0] == "thetinggoesskrra")
                {
                    break;
                }

                if (inputData.Length == 1)
                {
                    string newSetName = inputData[0];

                    if (!sets.ContainsKey(newSetName))
                    {
                        sets.Add(newSetName, new DataSet(newSetName));
                    }

                    if (cache.ContainsKey(newSetName))
                    {
                        sets[newSetName] = cache[newSetName];
                        cache.Remove(newSetName);
                    }

                    continue;
                }

                string dataKey = inputData[0];
                long dataSize = long.Parse(inputData[1]);
                string parentSet = inputData[2];

                if (dataSize < 0 || !isValid(dataKey) || !isValid(parentSet))
                {
                    continue;
                }

                if (sets.ContainsKey(parentSet))
                {
                    sets[parentSet].Keys.Add(dataKey);
                    sets[parentSet].Size += dataSize;
                }
                else
                {
                    if (!cache.ContainsKey(parentSet))
                    {
                        cache.Add(parentSet, new DataSet(parentSet));
                    }
                    cache[parentSet].Keys.Add(dataKey);
                    cache[parentSet].Size += dataSize;
                }
            }

            if (sets.Count > 0)
            {
                DataSet setToPrint = sets.Values.OrderByDescending(x => x.Size).First();
                if (setToPrint.Size > 0)
                {
                    Print(setToPrint);
                }
            }
        }

        private static void Print(DataSet set)
        {
            Console.WriteLine($"Data Set: {set.Name}, Total Size: {set.Size}");

            foreach (string key in set.Keys)
            {
                Console.WriteLine($"$.{key}");
            }
        }

        private static bool isValid(string word)
        {
            if (word.Contains('-') || word.Contains('>') || word.Contains('|'))
            {
                return false;
            }
            return true;
        }
    }

    public class DataSet
    {
        public DataSet(string name)
        {
            this.Name = name;
            this.Size = 0;
            this.Keys = new List<string>();
        }

        public string Name { get; set; }
        public long Size { get; set; }
        public List<string> Keys { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeNames
{
    class Program
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            //var list = new List<string>();
            //list.AddRange(names1);
            //list.AddRange(names2);
            //return list.Distinct().ToArray();

            return names1.Union(names2).Distinct().ToArray();
        }

        public static void Main(string[] args)
        {
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", Program.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
        }
    }
}

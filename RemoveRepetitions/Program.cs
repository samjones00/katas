using System;
using System.Collections.Generic;
using Xunit;

namespace RemoveRepetitions
{
    using System;
    using System.Collections.Generic;

    public class RemoveRepetitions
    {
        public static string Transform(string input)
        {
            var collection = new List<char>();
            collection.Add(input[0]);

            for (var i = 1; i < input.Length-1; i++)
            {
                var current = input[i];
                if (current != input[i-1])
                {
                    collection.Add(current);
                }
            }

            return string.Join("", collection);
        }

        public static void Main(string[] args)
        {
            Assert.Equal(RemoveRepetitions.Transform("abbcbbb"),"abcb");

            Console.WriteLine(RemoveRepetitions.Transform("abbcbbb"));
        }
    }
}

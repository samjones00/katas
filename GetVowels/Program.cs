using System;
using System.Linq;
using Xunit;

namespace GetVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = GetVowelCount4("abracadabra");
            Assert.Equal(5,result);
        }

        public static int GetVowelCount1(string str)
        {
            var vowels = new char[] {'a', 'e', 'i', 'o', 'u'};
            var strArr = str.ToCharArray();
            int vowelCount = 0;

            for (var i = 0; i < strArr.Count(); i++)
            {
                var c = strArr[i];

                if (vowels.Contains(c))
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }

        public static int GetVowelCount2(string str)
        {
            var vowels = "aeiou";
            var strArr = str.ToCharArray();
            int vowelCount = 0;

            for (var i = 0; i < strArr.Count(); i++)
            {
                var c = strArr[i];

                if (vowels.Contains(c))
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }

        public static int GetVowelCount3(string str)
        {
            var vowels = "aeiou";

            var vowelCount = "aeiou".Count(x => vowels.IndexOf(x) != -1);

            return vowelCount;
        }

        public static int GetVowelCount4(string str)
        {
            return str.Count(x => "aeiou".Contains(x));
        }
    }
}

using System.Linq;
using NUnit.Framework;

namespace Katas.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}, ExpectedResult = "(123) 456-7890")]
        [TestCase(new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, ExpectedResult = "(111) 111-1111")]
        public static string FixedTest(int[] numbers)
        {
            return Kata.CreatePhoneNumber3(numbers);
        }
    }

    public class Kata
    {
        public static string CreatePhoneNumber1(int[] numbers)
        {
            var str = string.Join("", numbers.SelectMany(x => x.ToString()));

            var result = $"({str.Substring(0, 3)}) {str.Substring(3, 3)}-{str.Substring(6, 4)}";

            return result;
        }

        public static string CreatePhoneNumber2(int[] numbers)
        {
            var str = string.Concat(numbers);

            var result = $"({str.Substring(0, 3)}) {str.Substring(3, 3)}-{str.Substring(6, 4)}";

            return result;
        }

        public static string CreatePhoneNumber3(int[] numbers)
        {
            var a = long.Parse(string.Concat(numbers));
            var b = a.ToString("(000) 000-0000");

            return b;
        }
    }
}

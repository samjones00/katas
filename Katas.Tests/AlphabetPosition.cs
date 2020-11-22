using System.Linq;
using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11",
                AlphabetPosition1("The sunset sets at twelve o' clock."));
            Assert.AreEqual("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20",
                AlphabetPosition1("The narwhal bacons at midnight."));
        }

        public static string AlphabetPosition1(string text)
        {
            return string.Join(' ', text.ToLower()
                .Where(char.IsLetter)
                .Select(x => "abcdefghijklmnopqrstuvwxyz".IndexOf(x) + 1)
            ).Trim();
        }

        public static string AlphabetPosition2(string text)
        {
            return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
        }
    }
}
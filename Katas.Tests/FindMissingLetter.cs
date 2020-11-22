using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    class FindMissingLetter
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual('e', FindMissingLetter3(new[] { 'a', 'b', 'c', 'd', 'f' }));
            Assert.AreEqual('P', FindMissingLetter3(new[] { 'O', 'Q', 'R', 'S' }));
        }

        public static char FindMissingLetter1(char[] array)
        {
            var lowerCaseAlphabetStartPosition=97;
            var positions = array.Select(x => x - 'a' + 1);
            int? previousPosition = null;

            foreach (var position in positions)
            {
                if (previousPosition.HasValue && position - 1 != previousPosition)
                {
                    return (char) (lowerCaseAlphabetStartPosition + previousPosition);
                }

                previousPosition = position;
            }

            return ' ';
        }

        public static char FindMissingLetter2(char[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i + 1] - array[i] > 1)
                {
                    return (char)(array[i] + 1);
                }
            }

            return ' ';
        }

        public static char FindMissingLetter3(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var current = array[i];
                var next = array[i+1];

                if (next - current > 1)
                {
                    return (char)(array[i] + 1);
                }
            }
            return ' ';
        }
    }
}

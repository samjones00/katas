using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(3, FindShort1("bitcoin take over the world maybe who knows perhaps"));
            Assert.AreEqual(3, FindShort2("turns out random test cases are easier than writing out basic ones"));
        }

        public static int FindShort1(string s)
        {
            return s.Split(' ').OrderBy(x => x.Length).First().Length;
        }

        public static int FindShort2(string s)
        {
            return s.Split(' ').Min(x => x.Length);
        }
    }
}

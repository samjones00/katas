using System;
using System.Collections.Generic;
using Xunit;

namespace TwoSum.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            TwoSum.FindTwoSum(new List<int>() {1, 3, 5, 7, 5, 9}, 10);

            Tuple<int, int> indices = TwoSum.FindTwoSum(new List<int>() { 1, 3, 5, 7, 5, 9 }, 10);

        }
    }
}

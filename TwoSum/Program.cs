using System;
using System.Collections.Generic;
using System.Linq;

public static class TwoSum
{
    public static Tuple<int, int> FindTwoSuma(IList<int> list, int sum)
    {
        int max = list.Max();
        for (int i = 0; i < list.Count - 1; i++)
        {
            int first = list[i];

            if (first + max == sum) return new Tuple<int, int>(i, list.IndexOf(max));

            if (first + max < sum) continue;

            for (int j = i + 1; j < list.Count; j++)
            {
                int second = list[j];
                if (sum == first + second)
                {
                    return new Tuple<int, int>(i, j);
                }
            }
        }
        return null;
    }

    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {
        var max = list.Max();

        for (var i = 0; i < list.Count-1; i++)
        {
            var first = list[i];

            if (first + max == sum)
            {
                return new Tuple<int, int>(i, list.IndexOf(max));
            }

            if (first + max < sum)
            {
                continue;
            }

            var match = GetSecondValue(first, list, sum);

            for (var j = 0; j < list.Count; j++)
            {
                var current = list[j];

                if (current != first)
                {
                    if (first + current == sum)
                        return new Tuple<int, int>(i, j);
                }
            }

            //for (int j = i + 1; j < list.Count; j++)
            //{
            //    int second = list[j];
            //    if (sum == first + second)
            //    {
            //        return new Tuple<int, int>(i, j);
            //    }
            //}

            if (match != null)
            {
                return new Tuple<int, int>(first, match.Value);
            }

        }

        return null;
    }

    private static int? GetSecondValue(int first, IList<int> available, int sum)
    {
        for (var i = 0; i < available.Count-1; i++)
        {
            var current = available[i];

            if (first + current == sum)
                    return current;
   
        }

        return null;
    }

    public static void Main(string[] args)
    {
        Tuple<int, int> indices = FindTwoSum(new List<int>() {1, 3, 5, 7, 5, 9}, 10);
        if (indices != null)
        {
            Console.WriteLine(indices.Item1 + " " + indices.Item2);
        }
    }
}
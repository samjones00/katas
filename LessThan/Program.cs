using System;
using System.Linq;
using System.Collections.Generic;

public class SortedSearch
{
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators#bitwise-complement-operator-
    //https://stackoverflow.com/questions/46376441/sorted-search-increase-performance/51171385

    public static int CountNumbersA(int[] sortedArray, int lessThan)
    {
        int lengthOfArray = sortedArray.Length;
        if (lengthOfArray == 0) return 0;

        if (sortedArray[0] >= lessThan) return 0;
        if (sortedArray[lengthOfArray - 1] < lessThan) return lengthOfArray;

        int index = Array.BinarySearch(sortedArray, lessThan);
        if (index < 0)
            return ~index;

        return index;
    }

    public static int CountNumbers(int[] sortedArray, int lessThan)
    {
        var i = Array.BinarySearch(sortedArray, lessThan);

        if (i < 0)
        {
            return ~i;
        }

        return i;
    }



    public static void Main(string[] args)
    {
        Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));
    }
}
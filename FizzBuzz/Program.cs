using System;

namespace FizzBuzz
{
    public class Program
    {
        private const string Fizz = "Fizz", Buzz = "Buzz";

        static void Main(string[] args)
        {
            Console.WriteLine($"Enter a number to apply {Fizz}{Buzz} to:");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            FizzBuzz(n);
        }

        public static void FizzBuzz(int n)
        {
            for (int i = 1; i < n + 1; i++)
            {
                Process(i);
            }
        }

        private static void Process(int n)
        {
            var isDivisibleByThree = n % 3 == 0;
            var isDivisibleByFive = n % 5 == 0;

            if (isDivisibleByThree && isDivisibleByFive)
            {
                Console.WriteLine($"{Fizz}{Buzz}");
            }

            if (isDivisibleByThree && !isDivisibleByFive)
            {
                Console.WriteLine(Fizz);
            }

            if (!isDivisibleByThree && isDivisibleByFive)
            {
                Console.WriteLine(Buzz);
            }

            if (!isDivisibleByThree && !isDivisibleByFive)
            {
                Console.WriteLine(n);
            }
        }
    }
}
// See https://aka.ms/new-console-template for more information
using System;
namespace array
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(numbers[i]);

                if (i % 2 == 0)
                {
                    Console.WriteLine("odd numbers of the array is : " + numbers[i]);

                }

                else if (i % 2 == 1)
                {
                    Console.WriteLine("even numbers of the array is : " + numbers[i]);
                }
                else
                {
                    Console.WriteLine("");
                }
                //int[] numberprime = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

                foreach (int number in numbers)
                {
                    bool isPrime = IsPrime(number);
                    if (isPrime)
                    {
                        Console.WriteLine($"{number} is a prime number");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is not a prime number");
                    }
                }
            }
            static bool IsPrime(int number)
            {
                if (number < 2)
                {
                    return false;
                }

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }

                return true;

            }
            //sum of all array prime numbers, even numbers, odd numbers.


            int[] num = { 1, 2, 3, 4, 5 };
            int sum = 0;
            foreach (int i in num)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}



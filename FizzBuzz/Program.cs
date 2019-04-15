using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Enumerable.Range(0, 106).ToList();

            //List<int> numbers = new List<int>() { 1, 2, (-3), 4, (-5), 15, (-105) };

            void FizzBuzz(int divByThree, int divByFive, int newMultiple, string newWord)
            {

                foreach(int number in numbers)
                {
                    string message = "";

                    if (number == 0)
                    {
                        Console.WriteLine($" {number}");
                        continue;
                    }
                    if (number % divByThree == 0)
                    {
                        message += "Fizz";
                    }
                    if (number % divByFive == 0)
                    {
                        message += "Buzz";
                    }
                    if (number % newMultiple == 0)
                    {
                        message += $"{newWord}";
                    }
                    Console.WriteLine($"{message} {number}");
                }
                Console.ReadLine();
            }
            FizzBuzz(3, 5, 7, "Jazz");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Problem 6.
// Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
// Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace DivisibleBy7And3
{
    class DivisibleBy7And3
    {
        static void Main()
        {
            var numbers = new List<int> { 1, 2, 3, 7, 24, 28, 9, 21, 6324, 45687, 
                                        8400, 654, 123, 210, 564, 840, 5, 454 };

            //Extension method
            var divisible = numbers.Where(n => n % 3 == 0 && n % 7 == 0);
            foreach (var item in divisible)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-',30));

            //LINQ
            divisible =
                from n in numbers
                where n % 3 == 0 && n % 7 == 0
                select n;
            foreach (var item in divisible)
            {
                Console.WriteLine(item);
            }
        }
    }
}

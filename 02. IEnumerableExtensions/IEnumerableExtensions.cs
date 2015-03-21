using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEnumerableExtensions
{
    static class IEnumerableExtensionsT
    {
        static void Main()
        {
            int[] collection = { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("Sum: {0}", collection.SumOf());
            Console.WriteLine("Product: {0}", collection.ProductOf());
            Console.WriteLine("Average: {0}", collection.AverageOf());
            Console.WriteLine("Max: {0}", collection.MaxOf());
            Console.WriteLine("Min: {0}", collection.MinOf());
        }

        public static T SumOf<T>(this IEnumerable<T> list)
        {
            T result = (dynamic)0;
            foreach (var item in list)
            {
                result += (dynamic)item;
            }

            return result;
        }

        public static T ProductOf<T>(this IEnumerable<T> list)
        {
            T result = (dynamic)1;
            foreach (var item in list)
            {
                result *= (dynamic)item;
            }

            return result;
        }

        public static T AverageOf<T>(this IEnumerable<T> list)
        {
            T result = (dynamic)0;
            foreach (var item in list)
            {
                result += (dynamic)item;
            }
            result /= (dynamic)list.Count();

            return result;
        }

        public static T MaxOf<T>(this IEnumerable<T> list) where T : IComparable
        {
            T max = (dynamic)0;
            foreach (var item in list)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T MinOf<T>(this IEnumerable<T> list) where T : IComparable
        {
            T min = (dynamic)0;
            foreach (var item in list)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }

            return min;
        }
    }
}

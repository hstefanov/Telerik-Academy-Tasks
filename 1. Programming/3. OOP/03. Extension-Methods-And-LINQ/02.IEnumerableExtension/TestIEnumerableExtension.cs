/*
 2.Implement a set of extension methods for IEnumerable<T> that implement the following group functions:
 sum, product, min, max, average.
*/

namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    public static class ExtensionsIEnumerable
    {
        public static T Sum<T>(this IEnumerable<T> arr)
        {
            dynamic sum = 0;
            foreach (var num in arr)
            {
                sum += (dynamic)num;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> arr)
        {
            dynamic product = 1;
            foreach (var num in arr)
            {
                product *= (dynamic)num;
                if (product == 0)
                    break;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> arr)
        {
            dynamic min = long.MaxValue;
            foreach (var num in arr)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> arr)
        {
            dynamic max = long.MinValue;
            foreach (var num in arr)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

        public static T Average<T>(this IEnumerable<T> arr)
        {
            dynamic average = 0, counter = 0;
            foreach (var num in arr)
            {
                average += num;
                counter++;
            }
            if (counter == 0)
                throw new ArgumentException("The passed collection is empty.");
            return average / counter;
        }
    }

    class TestIEnumerableExtension
    {
        static void Main()
        {
            int[] elements = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(elements.Sum<int>());
            Console.WriteLine(elements.Product<int>());
            Console.WriteLine(elements.Min<int>());         
            Console.WriteLine(elements.Max<int>());
            Console.WriteLine(elements.Average<int>());
        }
    }
}

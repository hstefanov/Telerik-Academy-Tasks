namespace MaxLengthString
{
    using System;
    using System.Linq;

    class MaxLengthString
    {
        static string[] words = new string[] { "private", "void", "static", "delegate", "method", "class","longeststring" };

        static void Main()
        {
            string longest = (from str in words
                              orderby str.Length descending
                              select str).ElementAt(0);

            Console.WriteLine("Longest string : {0}",longest);

        }
    }
}

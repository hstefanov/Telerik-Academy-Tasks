/*
 1.Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder 
 and has the same functionality as Substring in the class String.
*/

namespace ExtendStringBuilder
{
    using System;
    using System.Text;

    public static class ExtensionStrimgbuilder
    {
        public static StringBuilder Substring(this StringBuilder str, int startIndex, int length)
        {
            if (startIndex < 0 || startIndex >= str.Length || length < 1 || length > str.Length || startIndex + length > str.Length)
            {
                throw new ArgumentException("Ivalid input values");
            }

            StringBuilder substring = new StringBuilder();

            for (int i = startIndex, count = 0; count < length; i++, count++)
            {
                substring.Append(str[i]);
            }

            return substring;
        }
    }

    class TestExtension
    {
        static void Main()
        {
            StringBuilder testStringBuilder = new StringBuilder();

            testStringBuilder.Append("This is an extension method test!");

            Console.WriteLine(testStringBuilder.Substring(0, 4));
            Console.WriteLine(testStringBuilder.Substring(5, 2));
            Console.WriteLine(testStringBuilder.Substring(8, 2));
            Console.WriteLine(testStringBuilder.Substring(11, 9));
            Console.WriteLine(testStringBuilder.Substring(21, 6));
            Console.WriteLine(testStringBuilder.Substring(28, 5));
        }
    }
}

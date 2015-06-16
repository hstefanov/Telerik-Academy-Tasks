using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class Zerg
    {
        private static string[] zergDigits = { "Rawr", "Rrrr", "Hsst", "Ssst","Grrr","Rarr","Mrrr","Psst","Uaah",
                                               "Uaha","Zzzz","Bauu","Djav","Myau","Gruh" };

        static string ConvertToZergNumeralSystem(string input)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i+=4)
            {
                string zergDigit = input.Substring(i, 4);
                result.Append(Array.IndexOf(zergDigits, zergDigit));
            }
            return result.ToString();
        }
        static void Main()
        {
            string zergMessage = Console.ReadLine();

            string zergDigit = ConvertToZergNumeralSystem(zergMessage);

            ulong result = 0;
            for (int i = zergDigit.Length - 1, degree = 0; i >= 0; i--, degree++)
            {
                result += (ulong)zergDigit[i] * (ulong)Math.Pow(15, degree);
            }
            Console.WriteLine(result);
        }
    }
}

namespace LongestSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class LongestSubsequence
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            FindMaxSequence(numbers);
        }

        private static void FindMaxSequence(List<int> sequence)
        {
            int len = 1;
            int bestLen = 1;
            int start = 0;
            int bestStart = 0;

            for (int i = 0; i < sequence.Count - 1; i++)
            {
                if (sequence[i] != sequence[i + 1])
                {
                    len = 1;
                    start = i + 1;
                }
                else
                {
                    len++;
                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestStart = start;
                    }
                }
            }

            var longestSequence = new List<int>();

            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                longestSequence.Add(sequence[i]);
            }

            Console.Write("Best sequence : ");
            Console.Write("{");
            foreach (int num in longestSequence)
            {
                Console.Write(" " + num + " ");
            }
            Console.WriteLine("}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class GreeDyDwarf
    {
        static int CountCoins(int[] valley, string inputString)
        {
            string[] inputPattern = inputString.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] pattern = new int[inputPattern.Length];

            //fill pattern
            for (int i = 0; i < pattern.Length; i++)
            {
                pattern[i] = int.Parse(inputPattern[i]);
            }

            bool[] visited = new bool[valley.Length];
            int coins = 0;

            int valleyPos = 0;
            int patternPos = 0;

            while (valleyPos >= 0 && valleyPos < valley.Length && !visited[valleyPos])
            {
                coins += valley[valleyPos];
                visited[valleyPos] = true;
                valleyPos += pattern[patternPos];
                patternPos = (patternPos + 1) % pattern.Length;

            }
            return coins;
        }

        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] {',',' '},StringSplitOptions.RemoveEmptyEntries);
            int[] valley = new int[input.Length];

            //fill valley
            for (int i = 0; i < valley.Length; i++)
            {
                valley[i] = int.Parse(input[i]);
            }

            //number of patterns
            int numOfPatterns = int.Parse(Console.ReadLine());

            long maxCoins = int.MinValue;
            for (int i = 0; i < numOfPatterns; i++)
            {
                string currentPattern = Console.ReadLine();
                int currentCoins = CountCoins(valley, currentPattern);
                if (currentCoins > maxCoins)
                {
                    maxCoins = currentCoins;
                }
            }

            Console.WriteLine(maxCoins);
        }
    }
}

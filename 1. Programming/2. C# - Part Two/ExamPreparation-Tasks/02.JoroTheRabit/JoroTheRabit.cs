using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPreparation
{
    class JoroTheRabit
    {
        private static char[] separators = { ' ' ,','};
        static void Main()
        {
            string[] input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int[] terrain = new int[input.Length];
            for (int i = 0; i < terrain.Length; i++)
            {
                terrain[i] = int.Parse(input[i]);
            }

            int bestPath = int.MinValue;

            for (int startIndex = 0; startIndex < terrain.Length; startIndex++)
            {
                bool[] isVisited = new bool[terrain.Length];

                for (int step = 1; step < terrain.Length; step++)
                {
                    int startPostion = startIndex;
                    int currentPath = 1;
                    int next = (startPostion + step) % terrain.Length;

                    while(terrain[startPostion] < terrain[next])
                    {
                        currentPath++;
                        startPostion = next;
                        next = (startPostion + step) % terrain.Length;
                    }

                    if (bestPath < currentPath)
                    {
                        bestPath = currentPath;
                    }
                }
            }

            Console.WriteLine(bestPath);
        }
    }
}

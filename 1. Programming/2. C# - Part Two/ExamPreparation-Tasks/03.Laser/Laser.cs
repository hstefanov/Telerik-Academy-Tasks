using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ExamPreparation
{
    class Laser
    {
        static void Main()
        {
            int[] dims = GetNumbersFromConsole();
            int[] pos = GetNumbersFromConsole();
            int[] vect = GetNumbersFromConsole();

            bool[, ,] visited = new bool[dims[0] + 1, dims[1] + 1, dims[2] + 1];

            while (true)
            {
                visited[pos[0], pos[1], pos[2]] = true;
                int[] newPos = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    newPos[i] = pos[i] + vect[i];
                }

                if(visited[newPos[0],newPos[1],newPos[2]] || HowManyIndexesAreLimit(newPos,dims) >= 2)
                {
                    Console.WriteLine("{0} {1} {2}",pos[0],pos[1],pos[2]);
                    return;
                }

                if (HowManyIndexesAreLimit(newPos, dims) == 1)
                {
                    ReverseComponent(newPos, vect, dims);
                }
            }

        }

        private static void ReverseComponent(int[] newPos,int[] vect, int[] dims)
        {
            for (int i = 0; i < 3; i++)
            {
                if (newPos[i] == 1 && vect[i] == -1)
                {
                    vect[i] *= -1;
                }
                else if (newPos[i] == dims[i] && vect[i] == 1)
                {
                    vect[i] *= -1;
                }
            }
        }

        static int HowManyIndexesAreLimit(int[] pos, int[] dims)
        {
            int count = 0;

            for (int i = 0; i < 3; i++)
            {
                if (pos[i] == 1 || pos[i] == dims[i])
                {
                    count++;
                }
            }

            return count;
        }
        static int[] GetNumbersFromConsole()
        {
            string input = Console.ReadLine();
            string[] split = input.Split(' ');
            return split.Select(s => int.Parse(s)).ToArray();
        }
    }
}

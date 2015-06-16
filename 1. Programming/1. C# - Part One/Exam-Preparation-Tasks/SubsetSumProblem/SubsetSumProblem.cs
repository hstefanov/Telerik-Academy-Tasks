using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SubsetSumProblem
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int[] subset = new int[n];
        int counter = 0;

        for (int i = 0; i < n; i++)
        {
            subset[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i < 32; i++)
        {
            int sum = 0;
            for (int j = 0; j < subset.Length; j++)
            {
                sum += ((i >> j) & 1) * subset[j];
            }
            if (sum == s)
            {
                counter++;
            }
        }

        Console.WriteLine(counter);
    }
}


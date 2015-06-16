using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ForestRoad
{
    const char blank = '.';
    const char road = '*';

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int height = 2 * n - 1;

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            sb.Append(new string(blank, i));
            sb.Append(road);
            sb.Append(new string(blank, n - i - 1));
            sb.AppendLine();
        }

        for (int i = height - n; i > 0; i--)
        {
            sb.Append(new string(blank, i - 1));
            sb.Append(road);
            sb.Append(new string(blank, n - i));
            sb.AppendLine();
        }
        Console.WriteLine(sb);
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FirTree
{
    const char blank = '.';
    const char tree = '*';

    static void Main()
    {
        ushort n = ushort.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();

        for (int i = n - 2, j = 1; i >= 0; i--, j+=2)
        {
            sb.Append(new string(blank, i));
            sb.Append(new string(tree,j));
            sb.Append(new string(blank, i));
            sb.AppendLine();
        }

        sb.Append(new string(blank, n - 2));
        sb.Append(new string(tree,1));
        sb.Append(new string(blank, n - 2));

        Console.WriteLine(sb);
    }
}


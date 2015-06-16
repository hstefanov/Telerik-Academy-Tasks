using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SandClock
{
    static char blank = '.';
    static char clock = '*';

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i <= n / 2; i++)
        {
            sb.Append(new string('.', i));
            sb.Append(new string('*', n - 2*i));
            sb.Append(new string('.', i));
            sb.AppendLine();
        }

        for (int i = n / 2 - 1; i >= 0; i--)
        {
            sb.Append(new string('.', i));
            sb.Append(new string('*', n - 2*i));
            sb.Append(new string('.', i));
            sb.AppendLine();
        }
        Console.WriteLine(sb);
    }
}


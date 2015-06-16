using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Tribonacci
{
    static void Main()
    {
        int t1 = int.Parse(Console.ReadLine());
        int t2 = int.Parse(Console.ReadLine());
        int t3 = int.Parse(Console.ReadLine());
        int tn = 0;

        int n = int.Parse(Console.ReadLine());

        if (n == 1)
        {
            Console.WriteLine(t1);
        }
        if (n == 2)
        {
            Console.WriteLine(t2);
        }
        if (n == 3)
        {
            Console.WriteLine(t3);
        }
        else
        {
            for (int i = 4; i <= n; i++)
            {
                tn = t1 + t2 + t3;
                t1 = t2;
                t2 = t3;
                t3 = tn;
            }
        }
        Console.WriteLine(tn);
    }
}


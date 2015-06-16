using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] container = new int[n];

        for (int i = 0; i < n; i++)
        {
            int p = int.Parse(Console.ReadLine());
            int pLenght = Convert.ToString(p,2).Length;
            int pIverted = p;
            int pReversed = 0;
            string temp = string.Empty;

            for (int bit = 0; bit < pLenght; bit++)
            {
                pIverted ^= (1 << bit);
            }

            string pStr = Convert.ToString(p, 2);
            for (int bit = pLenght - 1; bit >= 0; bit--)
            {
                temp += pStr[bit];
            }

            pReversed = Convert.ToInt32(temp, 2);

            int pNew = (p ^ pIverted) & pReversed;
            container[i] = pNew;
        }

        foreach (var num in container)
        {
            Console.WriteLine(num);
        }
    }
}


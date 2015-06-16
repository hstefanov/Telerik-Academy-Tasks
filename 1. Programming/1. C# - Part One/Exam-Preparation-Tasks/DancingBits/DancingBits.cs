using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DancingBits
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int[] nums = new int[n];
        int numsLen = nums.Length;
        string concat = string.Empty;
        int dancingBits = 0;
        int len = 0;
        int lastBit = -1;
        
        for (int i = 0; i < numsLen; i++)
        {
            int num = int.Parse(Console.ReadLine());

            concat += Convert.ToString(num, 2);
        }

        int dancers = Convert.ToInt32(concat, 2);

        for (int i = concat.Length; i >= 0; i--)
        {
            int currentBit = (dancers >> i) & 1;
            if (currentBit == lastBit)
            {
                len++;
            }
            else
            {
                if (len == k)
                {
                    dancingBits++;
                }
                len = 1;
            }
            lastBit = currentBit;
        }

        if (len == k)
        {
            dancingBits++;
        }

        Console.WriteLine(dancingBits);
    }
}


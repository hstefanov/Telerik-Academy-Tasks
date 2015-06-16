using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class BinaryDigitsCount
    {
        static void Main()
        {
            int b = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] container = new int[n];

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                int sum = 0;

                foreach (char c in Convert.ToString(num, 2))
                {
                    if (int.Parse(c.ToString()) == b)
                    {
                        sum++;
                    }
                }
                container[i] = sum;
            }

            foreach (var res in container)
            {
                Console.WriteLine(res);
            }
        }
    }


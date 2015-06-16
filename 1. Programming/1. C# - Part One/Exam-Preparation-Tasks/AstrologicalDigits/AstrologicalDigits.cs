using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AstrologicalDigits
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
       
        while (true)
        {
            int result = 0;
            foreach (char c in n.ToString())
            {
                int temp = 0;
                int.TryParse(c.ToString(), out temp);
                result += temp;
            }
            n = result;
            if (n <= 9)
            {
                break;
            }
        }
        Console.WriteLine(n);
    }
}


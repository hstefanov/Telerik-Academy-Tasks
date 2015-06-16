using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program that generates and prints to the console 10 random values in the range [100, 200].
/// </summary>

class RandomValues
{
    static void Main()
    {
        Random rand = new Random();

        for (int i = 0; i < 10; i++)
        {
            int randomValue = rand.Next(100, 200);
            Console.WriteLine(randomValue);
        }
    }
}

using System;
using System.Linq;

class IfSort
{
    static void Main()
    {
        Console.WriteLine("Enter three real numbers :");
        double[] numbers = new double[3];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
        }


        //Използвал съм Linq и array.max() за по-голяма прегледност и по-малко вложени if-ове :)
        if (numbers.Max() == numbers[0])
        {
            if (numbers[1] > numbers[2])
            {
                Console.WriteLine("{0}, {1}, {2}", numbers[0], numbers[1], numbers[2]);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {3}",numbers[0],numbers[2],numbers[1]);
            }
        }
        else if (numbers.Max() == numbers[1])
        {
            if (numbers[0] > numbers[2])
            {
                Console.WriteLine("{0}, {1}, {2}", numbers[1], numbers[0], numbers[2]);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", numbers[1], numbers[2], numbers[0]);
            }
        }
        else
        {
            if (numbers[0] > numbers[1])
            {
                Console.WriteLine("{0}, {1}, {2}", numbers[2], numbers[0], numbers[1]);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", numbers[2], numbers[1], numbers[0]);
            }
        }
    }
}


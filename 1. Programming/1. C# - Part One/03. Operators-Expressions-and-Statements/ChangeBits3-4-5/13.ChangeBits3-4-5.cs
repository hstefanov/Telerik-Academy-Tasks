using System;

class ChangeBits3_4_5
{
    static void Main()
    {
        Console.WriteLine("Enter value for the number : ");
        Console.Write("numer = ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Number in binary before exchanging :");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        int mask = 7;

        int bits_3_4_5 = (number & (mask << 3)) >> 3;
        //Console.WriteLine(Convert.ToString(bits_3_4_5, 2).PadLeft(3,'0'));

        int bits_23_24_25 = (number & (mask << 23)) >> 23;
        //Console.WriteLine(Convert.ToString(bits_23_24_25, 2).PadLeft(3,'0'));

        //set bits 3,4,5 to zero
        number = (number & ~(mask << 3));
        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        //set bits 23,24,25 to zero
        number = (number & ~(mask << 23));
        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        number = number | (bits_3_4_5 << 23);
        number = number | (bits_23_24_25 << 3);
        Console.WriteLine("Number in binary after exchanging :");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

    }
}


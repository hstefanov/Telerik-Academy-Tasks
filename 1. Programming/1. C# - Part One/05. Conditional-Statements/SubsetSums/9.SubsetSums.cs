using System;

class SubsetSums
{
    static void Main()
    {
        Console.WriteLine("Enter five integer values :");
        int[] numbers = new int[5];
        int subSetCount = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i < 32; i++)
        {
            int sum = 0;
            for (int j = 0; j < 5; j++)
            {
                sum += ((i >> j) & 1) * numbers[j];
            }
            if (sum == 0)
            {
                subSetCount++;
            }
        }
        Console.WriteLine(subSetCount + " Subset sums = 0"); 
    }
}


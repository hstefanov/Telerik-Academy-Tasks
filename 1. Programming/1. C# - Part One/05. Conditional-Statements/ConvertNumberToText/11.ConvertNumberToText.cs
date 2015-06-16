using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ConvertNumberToText
{
    public static int[] numToArr(int num)
    {
        List<int> numlist = new List<int>();

        while (num > 0)
        {
            numlist.Add(num % 10);
            num = num / 10;
        }

        int[] numArr = numlist.ToArray();
        Array.Reverse(numArr);

        return numArr;
    }

    static void Main()
    {
        string[] digits = new String[] { "Zero", "One", "Two", "Three", "Tour", "Five", "Six", "Seven", "Eight", "Nine" };
        string[] tens = new String[] { "","","twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string[] specialDigits = new String[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };


        Console.WriteLine("Enter number : ");
        Console.Write("Number = ");
        int num = int.Parse(Console.ReadLine());

        int[] splitArr = numToArr(num);
        int arrLen = splitArr.Length;

        switch (arrLen)
        {
            case 1:
                Console.WriteLine(digits[splitArr[0]]);
                break;

            case 2:
                if (splitArr[0] == 1)
                {
                    Console.WriteLine(specialDigits[splitArr[1]]);
                }
                else
                {
                    Console.WriteLine(tens[splitArr[0]] + " " + digits[splitArr[1]]);
                }
                break;
            case 3:

                break;
        }
    }
}



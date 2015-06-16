/*
03.Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range.
It should hold error message and a range definition [start … end].
Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime>
by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
*/

namespace RangeExxception
{
    using System;

    class RangeExxceptionTest
    {
        static void Main()
        {
            Console.WriteLine("Please enter number between 1..100");
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number <= 0 || number > 100)
                {
                    throw new InvalidRangeException<int>(1, 100);
                }
                else
                {
                    Console.WriteLine("Number is correct!");
                }
            }
            catch (InvalidRangeException<int> intEx)
            {
                Console.WriteLine("InvalidRangeEcxeption : Number must be in range : " + intEx.Start + ".." + intEx.End);
            }

            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 1, 1);
            Console.WriteLine("Enter Date in the format 1/1/1980..1/1/2013");
            try
            {
                DateTime currentDate = DateTime.Parse(Console.ReadLine());
                if(currentDate.Year < 1980 || currentDate.Year > 2013)
                {
                    throw new InvalidRangeException<DateTime>(startDate,endDate);
                }
                else
                {
                    Console.WriteLine("Date is correct!");
                }
            }
            catch(InvalidRangeException<DateTime> dateEx)
            {
                Console.WriteLine("InvalidRangeException : Date must be in the range : " + dateEx.Start + ".." + dateEx.End);
            }
        }
    }
}

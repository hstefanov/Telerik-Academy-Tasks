namespace ReadIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Please enter positive integer : ");
            string inputLine = Console.ReadLine();
            int currentNumber;

            while (inputLine != string.Empty)
            {
                if (int.TryParse(inputLine, out currentNumber) && currentNumber > 0)
                {
                    numbers.Add(currentNumber);
                }
                else
                {
                    Console.WriteLine("Not a valid input integer.");
                }
                Console.WriteLine("Please enter positive integer : ");
                inputLine = Console.ReadLine();
            }

            Console.WriteLine("Sum : {0}\nAvarage : {1}",numbers.Sum(),numbers.Average());
        }
    }
}

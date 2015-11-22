namespace _02.ReverseIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ReverseIntegers
    {
        static void Main()
        {
            Console.WriteLine("Please enter a positive integer N (number of integers to be read)");
            int numberOfIntegers;
            bool isValidNumber = int.TryParse(Console.ReadLine(), out numberOfIntegers);

            while (!isValidNumber || numberOfIntegers <= 0)
            {
                Console.WriteLine("Invalid input number, try again...");
                Console.WriteLine("Please enter a positive integer N (number of integers to be read)");
                isValidNumber = int.TryParse(Console.ReadLine(), out numberOfIntegers);
            }

            var stackOfNumbers = new Stack<int>();

            for (int i = 0; i < numberOfIntegers; i++)
            {
                Console.WriteLine("Please enter an integer :");
                int currentNumber;
                isValidNumber = int.TryParse(Console.ReadLine(), out currentNumber);

                while (!isValidNumber)
                {
                    Console.WriteLine("Invalid integer, please try again...");
                    isValidNumber = int.TryParse(Console.ReadLine(), out currentNumber);
                }

                stackOfNumbers.Push(currentNumber);
            }

            Console.WriteLine("Entered numbers in reversed order :");
            while (stackOfNumbers.Count > 0)
            {
                Console.Write(stackOfNumbers.Pop() + " ");
            }
            Console.WriteLine();
        }
    }
}

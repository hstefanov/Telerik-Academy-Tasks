namespace QueueSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Program
    {
        static void Main()
        {
            //Using the Queue<T> class write a program to print its first 50 members for given N.
            //Example: N=2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...

            Console.WriteLine("Please enter the start number of the sequence : ");
            int n = int.Parse(Console.ReadLine());

            Queue<int> sequence = new Queue<int>();
            sequence.Enqueue(n);
            int count = 0;

            while (sequence.Count > 0)
            {
                if (count >= 50)
                {
                    break;
                }
                int current = sequence.Dequeue();
                count++;

                Console.WriteLine(current);
                
                sequence.Enqueue(current + 1);
                sequence.Enqueue(2 * current + 1);
                sequence.Enqueue(current + 2);
            }
        }
    }
}

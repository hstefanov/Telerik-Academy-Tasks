namespace Queue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class QueueImplementation
    {
        static void Main()
        {
            CustomQueue<int> customQueue = new CustomQueue<int>();
            customQueue.Enqueue(1);
            customQueue.Enqueue(10);
            customQueue.Enqueue(23);

            while (customQueue.Count != 0)
            {
                Console.WriteLine(customQueue.Dequeue());
            }
        }
    }
}

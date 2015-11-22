namespace OccurenceOfIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class OccurenceOfIntegers
    {
        static void Main()
        {
            var numbers = new[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            var groupedByOccurece = numbers
                                    .GroupBy(x => x)
                                    .OrderBy(x => x.Key);

            foreach (var group in groupedByOccurece)
            {
                Console.WriteLine("{0} --> {1} times", group.Key, group.Count());
            }
        }
    }
}

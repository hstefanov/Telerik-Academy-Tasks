namespace RemoveOddOccurence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RemoveOddOccurence
    {
        static void Main()
        {
            var numbers = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            var filteredNumbers = numbers
                                  .GroupBy(x => x)
                                  .Where(x => x.Count() % 2 == 0);

            var result = new List<int>();

            foreach (var group in filteredNumbers)
            {
                result.AddRange(group);
            }

            Console.WriteLine(
                "Initial sequence: {0};\nNumbers occuring even number of times: {1}",
                string.Join(", ", numbers),
                string.Join(", ", result));

        }
    }
}

namespace _08.FindMajorant
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class FindMajorant
    {
        static void Main()
        {
            var numbers = new[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            Console.WriteLine(string.Join(", ",numbers));
            var groupedByOccurence = numbers
                                        .GroupBy(x => x)
                                        .OrderByDescending(x => x.Count())
                                        .FirstOrDefault();
            if (groupedByOccurence != null && groupedByOccurence.Count() > numbers.Count() / 2)
            {
                Console.WriteLine("Majorant ---> {0} ({1} occurences)",groupedByOccurence.Key,groupedByOccurence.Count());
            }

            Console.WriteLine("No majorant givent in the curret sequence");
        }
    }
}

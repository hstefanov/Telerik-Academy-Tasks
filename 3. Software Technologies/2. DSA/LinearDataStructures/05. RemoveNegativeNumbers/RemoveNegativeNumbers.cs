namespace RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class RemoveNegativeNumbers
    {
        static void Main()
        {
            var initialList = new List<int> { 1, 0, -1, 5, 6, 7, -2, 3, -5 };
            var nonNegativeList = initialList.Where(x => x > 0);
            Console.WriteLine("Initial list : {0}\nNon negative list : {1}",
                string.Join(", ",initialList),
                string.Join(", ",nonNegativeList));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class KaspichanNumbers
    {
        static List<string> kaspichanNums = new List<string>();

        private static List<string> FillNumbers(List<string> numbers)
        {
            List<string> result = new List<string>();
            for (char i = 'A'; i <= 'Z'; i++)
            {
                result.Add(i.ToString());
            }
            for (char i = 'a'; i < 'i'; i++)
            {
                for (char j = 'A'; j <= 'Z'; j++)
                {
                    result.Add(i.ToString() + j.ToString());
                }
            }
            for (char i = 'A'; i <= 'V'; i++)
            {
                result.Add('i' + i.ToString());
            }
            return result;
        }


        static void Main()
        {
            kaspichanNums = FillNumbers(kaspichanNums);
            ulong inputNum = ulong.Parse(Console.ReadLine());
            string number = string.Empty;
            if (inputNum == 0)
            {
                Console.WriteLine('A');
            }

            while (inputNum > 0)
            {
                int index = (int)(inputNum % 256);
                number = kaspichanNums[index] + number;
                inputNum = inputNum / 256;
            }
            Console.WriteLine(number);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class GenomeDecoder
    {
        static string DecodeGenome(string encodedGenome)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder digits = new StringBuilder();

            for (int i = 0; i < encodedGenome.Length; i++)
            {
                if (char.IsDigit(encodedGenome[i]))
                {
                    digits.Append(encodedGenome[i]);
                }
                else
                {
                    if (digits.Length != 0)
                    {
                        int counter = int.Parse(digits.ToString());
                        for (int j = 0; j < counter; j++)
                        {
                            result.Append(encodedGenome[i]);
                        }
                        digits.Clear();
                    }
                    else
                    {
                        result.Append(encodedGenome[i]);
                    }
                }
            }
            return result.ToString();
        }

        static void Main()
        {
            string[] inputNums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = new int[inputNums.Length];
            for (int i = 0; i < numbers.Length; i++)
			{
			    numbers[i] = int.Parse(inputNums[i]);
			}

            string encodedGenome = Console.ReadLine();

            string decodedGenome = DecodeGenome(encodedGenome);
            //Console.WriteLine(decodedGenome);

            int decodedGenomeLen = decodedGenome.Length;

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < decodedGenomeLen; i++)
            {

            }
            Console.WriteLine(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class MovingLetters
    {
        static int getMaxWordLength(string[] wordSequence)
        {
            int maxLength = 0;
            for (int i = 0; i < wordSequence.Length; i++)
            {
                int currentLength = wordSequence[i].Length;
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }
            return maxLength;
        }


        static StringBuilder ExtractLetters(string[] wordSequence)
        {
            StringBuilder result = new StringBuilder();

            int maxLen = getMaxWordLength(wordSequence);
            int counter = 0;

            while (maxLen > 0)
            {
                for (int i = 0; i < wordSequence.Length; i++)
                {
                    if (wordSequence[i].Length - counter > 0)
                    {
                        result.Append(wordSequence[i][wordSequence[i].Length - 1 - counter]);
                    }
                }
                maxLen--;
                counter++;
            }
            
            return result;
        }

        static StringBuilder MoveLetters(StringBuilder extracted)
        {
            int movement = 0;
            for (int letter = 0; letter < extracted.Length; letter++)
            {
                movement = char.ToLower(extracted[letter]) - 'a' + letter + 1;
                char temp = extracted[letter];
                if (movement >= extracted.Length)
                {
                    movement = movement % extracted.Length;
                }
                extracted.Remove(letter, 1);
                extracted.Insert(movement, temp.ToString());
            }
            return extracted;
        }

        static void Main()
        {
            string[] wordSequence = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(MoveLetters(ExtractLetters(wordSequence)));


        }
    }
}

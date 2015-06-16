using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPreparation
{
    class DurankulakNumbers
    {
        private static string[] durankulakDigits = new string[168];

        private static string[] FillArray(string[] arr)
        {
            int counter = 0;
            for (char i = 'A'; i <= 'Z'; i++)
            {
                arr[counter] = i.ToString();
                counter++;
            }

            for (char i = 'a'; i <= 'e'; i++)
            {
                for (char j = 'A'; j <= 'Z'; j++)
                {
                    arr[counter] = i.ToString() + j.ToString();
                    counter++;
                }
            }

            for (char i = 'A'; i <= 'L'; i++)
            {
                arr[counter] = "f" + i.ToString();
                counter++;
            }

            return arr;
        }
        static void Main()
        {
            string durankulakNum = Console.ReadLine();
            FillArray(durankulakDigits);

            List<int> decimals = new List<int>();

            for (int i = 0; i < durankulakNum.Length; i++)
            {
                int num = 0;
                string temp = string.Empty;
                if (char.IsUpper(durankulakNum[i]))
                {
                    temp = string.Format("{0}", durankulakNum[i]);
                    num = Array.IndexOf(durankulakDigits, temp);
                    decimals.Add(num);
                }
                else
                {
                    temp = string.Format("{0}{1}", durankulakNum[i], durankulakNum[i + 1]);
                    num = Array.IndexOf(durankulakDigits,temp);
                    decimals.Add(num);
                    i++;
                }
            }

            ulong result = 0;
            for (int i = decimals.Count - 1,degree = 0; i >=0; i--,degree++)
            {
                result += (ulong)decimals[i] * (ulong)Math.Pow(168, degree);
            }
            Console.WriteLine(result);
        }
    }
}

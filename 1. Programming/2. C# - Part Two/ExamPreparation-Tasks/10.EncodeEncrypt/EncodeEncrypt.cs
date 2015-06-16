using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class EncodeEncrypt
    {
        static string Encode(string message)
        {
            StringBuilder result = new StringBuilder();

            int count = 1;
            char current = message[0];
            for (int i = 1; i < message.Length; i++)
            {
                if (current == message[i])
                {
                    count++;
                }
                else
                {
                    string encoded = String.Format("{0}{1}", count, current);
                    if (encoded.Length < count)
                    {
                        result.Append(encoded);
                    }
                    else
                    {
                        for (int j = 0; j < count; j++)
                        {
                            result.Append(current);
                        }
                    }
                    count = 1;
                    current = message[i];
                }
            }
            string lastEncoded = String.Format("{0}{1}", count, current);
            if (lastEncoded.Length > count)
            {
                result.AppendFormat("{0}{1}", count, current);
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    result.Append(current);
                }
            }
            
            return result.ToString();
        }


        static string Encrypt(string message, string cipher)
        {
            StringBuilder result = new StringBuilder();

            if (message.Length > cipher.Length)
            {
                for (int i = 0; i < message.Length; i++) 
                {
                    result.Append((char)(((message[i] - 'A') ^ cipher[i % cipher.Length] - 'A') + 'A'));
                }
            }
            else if(message.Length < cipher.Length)
            {
                for (int i = 0; i < cipher.Length; i++)
                {
                    
                }
            }

            return result.ToString();
        }

        static void Main()
        {
            string message = Console.ReadLine();
            string cipher = Console.ReadLine();
            Console.WriteLine(Encode(Encrypt(message,cipher) + cipher) + cipher.Length);
        }
    }
}

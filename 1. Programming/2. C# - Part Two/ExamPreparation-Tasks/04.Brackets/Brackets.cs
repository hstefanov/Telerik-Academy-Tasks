using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExamPreparation
{
    class Brackets
    {
        static int totalLines;
        static string identationString;
        static List<string> unformatedCode;
        static List<string> formatedCode;

        static void Input()
        {
            totalLines = int.Parse(Console.ReadLine());
            identationString = Console.ReadLine();

            unformatedCode = new List<string>(totalLines);
            formatedCode = new List<string>(totalLines);

            for (int i = 0; i < totalLines; i++)
            {
                unformatedCode.Add(Console.ReadLine());
            }
        }

        static string Trim(string line)
        {
            return Regex.Replace(line.TrimStart(), " +", " ");
        }


        static string MakeLine(string text, int level)
        {
            StringBuilder line = new StringBuilder();

            for (int i = 0; i < level; i++)
            {
                line.Append(identationString);
            }

            line.Append(text);

            return line.ToString();
        }


        static void FormatCode()
        {
            int stack = 0;

            //read line by line
            foreach (string line in unformatedCode)
            {
                //read char by char
                for (int i = 0; i < line.Length; i++)
                {
                    //start new line for each bracket
                    if (line[i] == '{')
                    {
                        formatedCode.Add(MakeLine("{", stack++));
                    }
                    else if (line[i] == '}')
                    {
                        formatedCode.Add(MakeLine("}", --stack));
                    }
                        //add contents to the new line
                    else
                    {
                        StringBuilder codeBuilder = new StringBuilder();

                        while (i < line.Length && line[i] != '{' && line[i] != '}')
                        {
                            codeBuilder.Append(line[i++]);
                        }

                        i--;
                        string code = codeBuilder.ToString();

                        if (!String.IsNullOrWhiteSpace(code))
                        {
                            formatedCode.Add(MakeLine(Trim(code), stack));
                        }
                    }
                }
            }
        }

        static void Output()
        {
            foreach (string line in formatedCode)
                Console.WriteLine(line);
        }

        static void Main()
        {
            Input();

            FormatCode();

            Output();
        }
    }
}

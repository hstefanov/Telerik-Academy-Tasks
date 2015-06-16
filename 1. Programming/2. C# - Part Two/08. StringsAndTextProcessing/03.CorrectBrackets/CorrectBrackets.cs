using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program to check if in a given expression the brackets are put correctly.
/// Example of correct expression: ((a+b)/5-d).
/// Example of incorrect expression: )(a+b)).
/// </summary>
class CorrectBrackets
{
    private static bool AreCorrectBrackets(string input)
    {
        Stack<string> stack = new Stack<string>();
        bool areCorrect = true;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                stack.Push("(");
            }
            else if (input[i] == ')')
            {
                if (stack.Count == 0)
                {
                    areCorrect = false;
                    break;
                }
                stack.Pop();
            }
        }
        if (stack.Count != 0)
        {
            areCorrect = false;
        }
        return areCorrect;
    }

    static void Main()
    {
        string expression = "((a+b)/5-d)";
        Console.WriteLine("Are brackets correct : {0}",AreCorrectBrackets(expression));
    }
}

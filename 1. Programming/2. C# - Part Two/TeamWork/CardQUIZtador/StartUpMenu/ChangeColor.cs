using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUpMenu
{
    class ChangeColor
    {
         public const string quiz = @"

                        ██████   ██  ██   ██   ████████  ██
                        ██████   ██  ██   ██   ████████  ██
                        ██  ██   ██  ██   ██       █ ██  ██
                        ██  ██   ██  ██   ██      █ █    ██
                        ██  ██   ██  ██   ██     █ █     ██
                        ██  ██   ██  ██   ██    █ █      ██
                        ██  ██   ██  ██   ██   █ █       ██
                        ██████   ██████   ██   ████████ 
                        ██████   ██████   ██   ████████  ██
                        ";

       public static void Blink(string str,int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(str);
            System.Threading.Thread.Sleep(600);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(left, top);
            Console.WriteLine(str);
            System.Threading.Thread.Sleep(600);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(left, top);
            Console.WriteLine(str);
            System.Threading.Thread.Sleep(600);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(left, top);
            Console.WriteLine(str);
            System.Threading.Thread.Sleep(600);
        }
    }
}

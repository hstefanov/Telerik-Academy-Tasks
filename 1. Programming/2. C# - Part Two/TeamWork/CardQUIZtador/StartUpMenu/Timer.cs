using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUpMenu
{
    class Timer
    {
        const string frame = "█";

        public static void PrintTimer(int originalStartValueLeft, int originalStartValueTop)
        {
            int cursorLeft = originalStartValueLeft + 1;
            int cursorTop = originalStartValueTop - 1;
            int counter = 15;
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(cursorLeft - 1, cursorTop + 1);
                Console.Write(frame);
                cursorLeft = Console.CursorLeft;
                cursorTop = Console.CursorTop;
                if (i % 2 == 0)
                {
                    Console.SetCursorPosition(originalStartValueLeft + 2, originalStartValueTop + 2);
                    Console.WriteLine(counter);
                    counter--;
                }
                System.Threading.Thread.Sleep(1000);
            }
            for (int i = 1; i <= 5; i++)
            {
                Console.SetCursorPosition(cursorLeft, cursorTop);
                Console.Write(frame);
                cursorLeft = Console.CursorLeft;
                cursorTop = Console.CursorTop;
                if (i % 2 == 0 || i == 3 || i == 5)
                {
                    Console.SetCursorPosition(originalStartValueLeft + 2, originalStartValueTop + 2);
                    Console.WriteLine("{0}", counter.ToString("D2"));
                    counter--;
                }
                System.Threading.Thread.Sleep(1000);
            }
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(cursorLeft - 1, cursorTop - 1);
                Console.Write(frame);
                cursorLeft = Console.CursorLeft;
                cursorTop = Console.CursorTop;
                Console.SetCursorPosition(originalStartValueLeft + 2, originalStartValueTop + 2);
                Console.WriteLine("{0}", counter.ToString("D2"));
                counter--;
                System.Threading.Thread.Sleep(1000);
            }
            for (int i = 0; i < 4; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(cursorLeft - 2, cursorTop);
                Console.Write(frame);
                cursorLeft = Console.CursorLeft;
                cursorTop = Console.CursorTop;
                Console.SetCursorPosition(originalStartValueLeft + 2, originalStartValueTop + 2);
                Console.WriteLine("{0}", counter.ToString("D2"));
                counter--;
                System.Threading.Thread.Sleep(1000);
            }
            Console.SetCursorPosition(originalStartValueLeft + 2, originalStartValueTop + 2);
            Console.WriteLine("00");
            Console.SetCursorPosition(0, 2);
        }
    }
}

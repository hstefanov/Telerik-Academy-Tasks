using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


  public static class Instructions
    {
      static public string body = ((char)(3)).ToString() + ((char)(6)).ToString()
            + ((char)(4)).ToString() + ((char)(5)).ToString();

      public static string instructions = @"

                    █ ▄▄  ▄ ▄▄▄ ▄▄▄ ▄▄▄ ▄ ▄ ▄▄▄ ▄▄▄ ▄ ▄▄▄ ▄▄  ▄ ▄▄▄   
                    █ █ █ █ █▄▄  █  █▄█ █ █ █    █  █ █ █ █ █ █ █▄▄
                    █ █  ██ ▄▄█  █  █▀▄ █▄█ █▄▄  █  █ █▄█ █  ██ ▄▄█
                                              ";
      public static string line = new String('▄', 88);

      public static void PrintInstructionsPage()
      {
          Console.Clear();
          PrintAt(instructions, 0, 2, ConsoleColor.Green);
          PrintAt(body, 14, 5, ConsoleColor.Red);
          PrintAt(body, 69, 5, ConsoleColor.Red);
          PrintAt(line, 0, 10, ConsoleColor.Green);
          Console.OutputEncoding = Encoding.UTF8;
          Console.SetCursorPosition(0, 44);
          PrintBackButton();
          
      }
      public static void PrintAt(string str,int left, int top, ConsoleColor color)
      {
          Console.SetCursorPosition(left, top);
          Console.ForegroundColor = color;
          Console.WriteLine(str);
      }
        static void Main(string[] args)
        {
            Console.SetWindowSize(88, 45);
            Console.BufferHeight = Console.WindowHeight = 45;
            Console.BufferWidth = Console.WindowWidth = 88;
            PrintInstructionsPage();
            PrintBackButton();
        }

        private static void PrintBackButton()
        {
            string backToMenu = "PRESS ESC TO RETURN TO MAIN MENU";
            Console.SetCursorPosition(0, 44);
            Console.Write(backToMenu);
            ConsoleKeyInfo pressedKey = Console.ReadKey(true);           
            if (pressedKey.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("-----BACK TO MENU METHOD HERE-----");
                
                
            }
            
        }
    }


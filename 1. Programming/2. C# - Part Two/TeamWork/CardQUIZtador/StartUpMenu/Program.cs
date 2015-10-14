using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StartUpMenu;
using System.Drawing;
using System.Media;

namespace StartUpMenu
{
    

    public static class Program
    {
        public const string title = @"
    █████               ██ ██████ ██  ██ ██ ████████ ██                ██    
    █████               ██ ██████ ██  ██ ██ ████████ ██                ██  
    ██    ██████ ███    ██ ██  ██ ██  ██ ██     █ ████████  ██████     ██ ██████ ███
    ██        ██ ██     ██ ██  ██ ██  ██ ██    █ █   ██         ██     ██ ██  ██ ██
    ██    ██████ ██ ██████ ██  ██ ██  ██ ██   █ █    ██     ██████ ██████ ██  ██ ██
    ██    ██  ██ ██ ██  ██ ██  ██ ██  ██ ██  █ █     ██     ██  ██ ██  ██ ██  ██ ██
    ██    ██  ██ ██ ██  ██ ██  ██ ██  ██ ██ █ █      ██     ██  ██ ██  ██ ██  ██ ██
    █████ ██  ██ ██ ██  ██ ██████ ██████ ██ ████████ ██  ██ ██  ██ ██  ██ ██  ██ ██
    █████ ██████ ██ ██████ ██████ ██████ ██ ████████ ██████ ██████ ██████ ██████ ██
                                   
    ";
        public const string newGAme = @"
                             
                           ██  █ ▄▄▄ ▄▄   ▄▄  █▀▀  ▄▄▄▄ ▄▄▄▄▄ ▄▄▄
                           █ █ █ █▄▄  █ ▄ █   █ ▄▄ █▄▄█ █ █ █ █▄▄
                           █  ██ █▄▄  █▄█▄█   █▄▄█ █  █ █ █ █ █▄▄
                                       
                                          ";


        public const string instructions = @"

                           █ ▄▄  ▄ ▄▄▄ ▄▄▄ ▄▄▄ ▄ ▄ ▄▄▄ ▄▄▄ ▄ ▄▄▄ ▄▄  ▄ ▄▄▄   
                           █ █ █ █ █▄▄  █  █▄█ █ █ █    █  █ █ █ █ █ █ █▄▄
                           █ █  ██ ▄▄█  █  █▀▄ █▄█ █▄▄  █  █ █▄█ █  ██ ▄▄█
                                              ";

        public const string exit = @"
                           ▄▄▄▄ ▄   ▄ ▄ ▄▄▄
                           █▄▄▄  ▀▄▀  █  █
                           █     ▄▀▄  █  █
                           ▀▀▀▀ ▀   ▀ ▀  ▀   

                                       ";
        public static string line = new String('▄', 44);


        public static void PrintOnPosition(int x, int y, string s, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(s);
        }

        public static void DrawMenu()
        {
            Console.Clear();
            
            Console.SetWindowSize(88, 45);
            Console.BufferHeight = Console.WindowHeight = 45;
            Console.BufferWidth = Console.WindowWidth = 88;
            Console.Title = "CardQUIZtador";
            Pointer.x = 20;
            Pointer.y = 23;
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }

                    if (pressedKey.Key == ConsoleKey.UpArrow)
                    {
                        if (Pointer.y > 23)
                        {                            
                            Pointer.y -= 5;
                            SoundArrow();
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.DownArrow)
                    {
                        if (Pointer.y < 31)
                        {                            
                            Pointer.y += 5;
                            SoundArrow();
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.Enter)
                    {
                        SoundEnter();
                        if (Pointer.y == 23) //start new game Method
                        {
                            PlayGame.StartGame();
                            break;
                        }
                        else if (Pointer.y == 28)//instructions
                        {                                                        
                            Instruction.MainMethodForInstructions();                            
                        }
                        else if (Pointer.y == 33)
                        {
                            Console.SetCursorPosition(0, 44);
                            Environment.Exit(1);
                        }
                    }
                }

                PrintOnPosition(30, 2, title, ConsoleColor.Blue);
                PrintOnPosition(0, 13, line, ConsoleColor.Blue);
                PrintOnPosition(44, 13, line, ConsoleColor.Green);
                PrintOnPosition(40, 20, newGAme, ConsoleColor.Green);
                PrintOnPosition(40, 25, instructions, ConsoleColor.Green);
                PrintOnPosition(40, 31, exit, ConsoleColor.Green);
                PrintOnPosition(Pointer.x, Pointer.y, Pointer.body, ConsoleColor.Red);

                System.Threading.Thread.Sleep(200);

            }
        }        

        static void Main()
        {
            Console.CursorVisible = false;
            DrawMenu();
        }

        public static void SoundArrow()
        {
            var sound = new SoundPlayer(@"Blop_forArrow.wav");
            sound.PlaySync();            
        }

        public static void SoundEnter()
        {
            var sound = new SoundPlayer(@"spin_whenEnter.wav");
            sound.PlaySync();
        }
    }
}

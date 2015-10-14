using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace StartUpMenu
{
    public static class Instruction
    {
        static string body = ((char)(3)).ToString() + ((char)(6)).ToString()
              + ((char)(4)).ToString() + ((char)(5)).ToString();

        public const string instructions = @"

                    █ ▄▄  ▄ ▄▄▄ ▄▄▄ ▄▄▄ ▄ ▄ ▄▄▄ ▄▄▄ ▄ ▄▄▄ ▄▄  ▄ ▄▄▄   
                    █ █ █ █ █▄▄  █  █▄█ █ █ █    █  █ █ █ █ █ █ █▄▄
                    █ █  ██ ▄▄█  █  █▀▄ █▄█ █▄▄  █  █ █▄█ █  ██ ▄▄█
                                              ";
        const string cardsText = "CARDS";
        const string quizText = "THE QUIZ!";
        const string winnerText = "WHO WINS?";
        const string textInstructions = @" 
                                      
            A standart deck of 52 cards is equally separated between the
         two players(26 cards each player).
         When you hit ""ENTER"" the top card of your deck and the top card of your
         opponent's deck are shown on the table. Whose card is more powerfull,
         gets 1 point.
         Cards rank(from highest to lowest)- A,K,Q,J,10,9,8,7,6,5,4,3,2!
         If the two shown on the table cards are equal, we have 
         a QUIZ situation!

                                     
            When there are equal cards on the table or cards from one suit, 
         it's a QUIZ! Now you and your opponent have to answer a question
         from random area(history, IT, geography, culture, filmography etc.).
         You will have 15 seconds to give an answer (A,B or C).
         If you answer correctly and your opponent doesn't, you get 2 points
         and if you give a wrong answer and your opponent correct one, he 
         gets 2 points. In case both, you and your opponent, answer correctly,
         another question is asked and the points are doubled. If both of you
         give an wrong answers, nobody wins nothing and the CARDS are back!
    
                                     

            Winner is the one who has more points after turning all cards!  
                                                                                   
         Enjoy!";


        public static string line = new String('▄', 88);

        public static void PrintInstructionsPage()
        {
            Console.Clear();
            PrintAt(instructions, 0, 2, ConsoleColor.Green);
            PrintAt(body, 14, 5, ConsoleColor.Red);
            PrintAt(body, 69, 5, ConsoleColor.Red);
            PrintAt(line, 0, 10, ConsoleColor.Green);
            PrintAt(cardsText, 39, 15, ConsoleColor.Red);
            PrintAt(quizText, 37, 25, ConsoleColor.Red);
            PrintAt(winnerText, 37, 37, ConsoleColor.Red);
            PrintAt(textInstructions, 0, 15, ConsoleColor.Green);
            Console.SetCursorPosition(0, 44);
            PrintBackButton();

        }
        public static void PrintAt(string str, int left, int top, ConsoleColor color)
        {
            Console.SetCursorPosition(left, top);
            Console.ForegroundColor = color;
            Console.WriteLine(str);
        }
        public static void MainMethodForInstructions()
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
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }

                    if (pressedKey.Key == ConsoleKey.Escape)
                    {
                        SoundEscape();
                        Console.Clear();
                        Program.DrawMenu();                        
                    }

                }
                

            }
        }

        private static void SoundEscape()
        {
            var sound = new SoundPlayer(@"spin_whenEnter.wav");
            sound.PlaySync();
        }

    }
}

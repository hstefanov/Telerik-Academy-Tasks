using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace StartUpMenu
{
    public static class Question
    {
        private static string[] content;
        private static int correctAnswer;

        public static string[] Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }
        public static int CorrectAnswer
        {
            get
            {
                return correctAnswer;
            }
            set
            {
                correctAnswer = value;
            }
        }
        public static Random rand = new Random();

        public static void PrintQuestion()
        {
            Console.Clear();
            int x = Question.Content.Length / 2;
            Pointer.x = 30;
            Pointer.y = 7;
            //Timer.PrintTimer(40, 20);
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                    if (pressedKey.Key == ConsoleKey.UpArrow)
                    {
                       
                        if (Pointer.y > 7)
                        {
                            //Program.SoundArrow();     
                            Pointer.y -= 5;
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.DownArrow)
                    {
                        
                        if (Pointer.y < 17)
                        {
                            //Program.SoundArrow();
                            Pointer.y += 5;
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.Enter)
                    {
                        if (Pointer.y == 7)
                        {
                            HumanPlayer.Choice = 1; // ANSWER A)
                            break;
                        }
                        else if (Pointer.y == 12)
                        {
                            HumanPlayer.Choice = 2; //ANSWER B)
                            break;
                        }
                        else if (Pointer.y == 17)
                        {
                            HumanPlayer.Choice = 3; //ANSWER C)
                            break;
                        }
                    }
                }

                try
                {
                Console.SetCursorPosition(x, 2);
                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + content[0].Length / 2) + "}", content[0]);

                //print answers                
                Console.SetCursorPosition(Pointer.x + 10, 7);
                Console.WriteLine(string.Format("{0}:  {1}", "A", content[1]).PadLeft(5));


                Console.SetCursorPosition(Pointer.x + 10, 12);
                Console.WriteLine(string.Format("{0}:  {1}", "B", content[2]).PadLeft(5));


                Console.SetCursorPosition(Pointer.x + 10, 17);
                Console.WriteLine(string.Format("{0}:  {1}", "C", content[3]).PadLeft(5));
                Program.PrintOnPosition(Pointer.x, Pointer.y, Pointer.body, ConsoleColor.Red);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("We apologize for inconvenience, but there are no more questions!");
                }


                System.Threading.Thread.Sleep(200);
            }


            //Computer guess:
            PcPlayer.Choice = rand.Next(1, 4);

            //Points for correct answer
            if (HumanPlayer.Choice == Question.CorrectAnswer)
            {
                HumanPlayer.Points += 2; //due to rules;
            }
            if (PcPlayer.Choice == Question.CorrectAnswer)
            {
                PcPlayer.Points += 2; //due to rules;
            }


            //print choice
            Console.SetCursorPosition(30, 18);
            Console.WriteLine("Your choice is: {0}", Question.Content[HumanPlayer.Choice]);

            Console.SetCursorPosition(30, 22);
            Console.WriteLine("Computer choice is: {0}", Question.Content[PcPlayer.Choice]);

            System.Threading.Thread.Sleep(1000);
            Console.SetCursorPosition(30, 26);
            Console.WriteLine("Correct answer is: {0}", Question.Content[Question.CorrectAnswer]);

            if (HumanPlayer.Choice == Question.CorrectAnswer && PcPlayer.Choice != Question.CorrectAnswer)
                SoundCorrectAnswerHuman();
            else if (HumanPlayer.Choice == Question.CorrectAnswer && PcPlayer.Choice == Question.CorrectAnswer)
                SoundCorrectAnswerBoth();
            else if (HumanPlayer.Choice != Question.CorrectAnswer && PcPlayer.Choice == Question.CorrectAnswer)
            {
                SoundWrongAnswer();
                SoundWrongAnswer2();
                SoundWrongAnswer();
            }
            else if (HumanPlayer.Choice != Question.CorrectAnswer && PcPlayer.Choice != Question.CorrectAnswer)
            {
                SoundWrongAnswer();
                SoundWrongAnswer2();
                SoundWrongAnswer();
            }

            System.Threading.Thread.Sleep(500);
            Console.Clear();            
            if (HumanPlayer.Choice == Question.CorrectAnswer && PcPlayer.Choice == Question.CorrectAnswer)
            {
                War.CurrentQuestion();
            }
        }

        private static void SoundArrow()
        {
            var sound = new SoundPlayer(@"Blop_forArrow.wav");
            sound.PlaySync();
        }

        private static void SoundEnter()
        {
            var sound = new SoundPlayer(@"spin_whenEnter.wav");
            sound.PlaySync();
        }

        private static void SoundDominating()
        {
            var sound = new SoundPlayer(@"dominating.wav");
            sound.PlaySync();
        }

        private static void SoundWrongAnswer()
        {
            var sound = new SoundPlayer(@"Punch_whenShowingCards.wav");
            sound.PlaySync();
        }

        private static void SoundWrongAnswer2()
        {
            var sound = new SoundPlayer(@"Slap_wrongAnswer.wav");
            sound.PlaySync();
        }

        private static void SoundCorrectAnswerHuman()
        {
            var sound = new SoundPlayer(@"CrowdCheer_endGame.wav");
            sound.PlaySync();
        }

        private static void SoundCorrectAnswerBoth()
        {
            var sound = new SoundPlayer(@"Triumphal_whenWar.wav");
            sound.PlaySync();
        }

    }
}

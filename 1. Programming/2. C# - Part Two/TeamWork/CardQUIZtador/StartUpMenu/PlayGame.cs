using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace StartUpMenu
{
     static class PlayGame
    {
        public static Random rnd = new Random();

        // coordinates of cards and cardpiles on the console
        public  const int PcCardX = 37;
        public  const int PcCardY = 10;
        public  const int HumCardX = 37;
        public  const int HumCardY = 22;
        public  const int PcCardPileX = 61;
        public  const int PcCardPileY = 2;
        public  const int HumCardPileX = 10;
        public  const int HumCardPileY = 29;
        public  const int dealsEnd = 26;



        public static void StartGame()
        {
            string[] cards = new string[] {"2c","3c","4c","5c","6c","7c","8c","9c","Tc","Jc","Qc","Kc","Ac",
                                           "2d","3d","4d","5d","6d","7d","8d","9d","Td","Jd","Qd","Kd","Ad",
                                           "2h","3h","4h","5h","6h","7h","8h","9h","Th","Jh","Qh","Kh","Ah",
                                           "2s","3s","4s","5s","6s","7s","8s","9s","Ts","Js","Qs","Ks","As"};
            cards = cards.OrderBy(x => rnd.Next()).ToArray();

            Console.CursorVisible = false;

            //Deal cards to both players
            List<string> cardsList = new List<string>(cards);
            string[] pcPlayerCards = new string[26];
            string[] humanPlayerCards = new string[26];
            for (int i = 0; i < 52; i++)
            {
                if (i < 26)
                {
                    pcPlayerCards[i] = cardsList[i];
                }
                else
                {
                    humanPlayerCards[i - 26] = cardsList[i];
                }
            }

            Card PCcard = new Card();
            Card Humancard = new Card();

            Console.Clear();
            Card.DrawCardPile(PcCardPileX, PcCardPileY);       // PC cardpile
            Card.DrawCardPile(HumCardPileX, HumCardPileY);      // Human cardpile
            PressButtonToContinue();
            for (int deals = 0; deals < dealsEnd; deals++)
            {
                //draw cards
                Console.Clear();
                PrintScore();
                Card.DrawCardPile(PcCardPileX, PcCardPileY);
                Card.DrawCardPile(HumCardPileX, HumCardPileY);

                PCcard = new Card(pcPlayerCards[deals]);
                Humancard = new Card(humanPlayerCards[deals]);

                // visualise cards
                SoundShowingCards();
                Card.DrawCardBack(PcCardX, PcCardY);
                System.Threading.Thread.Sleep(500);
                Card.DrawCardUp(PcCardX, PcCardY, PCcard);
                System.Threading.Thread.Sleep(500);
               
                Card.DrawCardBack(HumCardX, HumCardY);
                System.Threading.Thread.Sleep(500);
                Card.DrawCardUp(HumCardX, HumCardY, Humancard);

                //who wins
                if (PCcard.Value > Humancard.Value && PCcard.Color != Humancard.Color)         // PC wins a point
                {
                    System.Threading.Thread.Sleep(500);
                    Card.BlinkCard(PcCardX, PcCardY, PCcard);
                    SoundWhenLose();
                    PcPlayer.Points++;
                }
                else if (PCcard.Value < Humancard.Value && PCcard.Color != Humancard.Color)    // Human wins a point
                {
                    System.Threading.Thread.Sleep(500);
                    Card.BlinkCard(HumCardX, HumCardY, Humancard);
                    SoundWhenWin();
                    HumanPlayer.Points++;
                }
                else
                {
                    System.Threading.Thread.Sleep(300);                 // when war - blink both cards
                    Card.BlinkCard(PcCardX, PcCardY, PCcard);
                    System.Threading.Thread.Sleep(300);
                    Card.BlinkCard(HumCardX, HumCardY, Humancard);
                    SoundWhenWar();
                    Console.Clear();
                    ChangeColor.Blink(ChangeColor.quiz, 55 ,15);
                    System.Threading.Thread.Sleep(300);
                    Console.ResetColor();                    
                    War.CurrentQuestion();                    
                   // Question.PrintQuestion();
                    Card.DrawCardPile(PcCardPileX, PcCardPileY);       // PC cardpile
                    Card.DrawCardPile(HumCardPileX, HumCardPileY);      // Human cardpile
                }
                if (deals==dealsEnd-1)
                {
                    continue;                    
                }
                PressButtonToContinue();         
            }
            PrintFinalMessage();
        }

        private static void PrintFinalMessage()
        {

            if (HumanPlayer.Points == PcPlayer.Points)
            {
                do
                {
                    War.CurrentQuestion();
                } while (HumanPlayer.Points==PcPlayer.Points);
                
            }

            if (HumanPlayer.Points!=PcPlayer.Points)
            {
                if (HumanPlayer.Points > PcPlayer.Points)
                {
                    //you win
                    Console.Clear();
                    Program.PrintOnPosition(45, 10, youWon, ConsoleColor.Green);
                }
                else if (HumanPlayer.Points < PcPlayer.Points)
                {
                    //you lost
                    Console.Clear();
                    Program.PrintOnPosition(45, 10, youLost, ConsoleColor.Red);
                }
            }
            
           
        }

        private static void PrintScore()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(11, 3);
            Console.WriteLine("Opponent Score: {0}",PcPlayer.Points);
            Console.SetCursorPosition(64, 38);
            Console.WriteLine("My Score: {0}",HumanPlayer.Points);
        }

        private static void PressButtonToContinue()
        {
            Console.SetCursorPosition(34, 40);
            Console.WriteLine("Press ENTER to DEAL");            
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }

                    if (pressedKey.Key == ConsoleKey.Enter)
                    {
                        return;
                    }
                }
            }
        }

        private static void SoundShowingCards()
        {
            var sound = new SoundPlayer(@"Puk_whenShowingCards.wav");
            sound.PlaySync();
        }

        private static void SoundWhenWin()
        {
            var sound = new SoundPlayer(@"Ta Da.wav");
            sound.PlaySync();
        }

        private static void SoundWhenLose()
        {
            var sound = new SoundPlayer(@"Evil_laugh_Male_endGame.wav");
            sound.PlaySync();
        }

        private static void SoundWhenWar()
        {
            var sound = new SoundPlayer(@"Gong_whenWar.wav");
            sound.PlaySync();
        }
        public static string youWon = @"

                              
                    ███   ███      ███        ███         ██
                     ███ ███        ███      ███          ██     
                       ███ ▄▄▄ ▄ ▄   ███ ██ ███ ▄▄▄ ▄▄  ▄ ██
                      ███  █ █ █ █    ████████  █ █ █ █ █ 
                     ███   █▄█ █▄█     ██  ██   █▄█ █  ██ ██

                              ";

        public static string youLost = @"

                    ███   ███       ██                 ██
                     ███ ███        ██                 ██
                       ███ ▄▄▄ ▄ ▄  ██     ▄▄▄ ▄▄▄ ▄▄▄ ██
                      ███  █ █ █ █  ██     █ █ █▄▄  █
                     ███   █▄█ █▄█  ██████ █▄█ ▄▄█  █  ██

                             ";
    }
}

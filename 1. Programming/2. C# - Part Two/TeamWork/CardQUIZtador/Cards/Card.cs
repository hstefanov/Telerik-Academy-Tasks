using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class Card
{
    static void Main()
    {
    }

    private int value;    // 2-14
    private int color;    // h-3, d-4, c-5, s-6

    public int Value
    {
        get
        {
            return this.value;
        }
        set
        {
            this.value = value;
        }
    }

    public int Color
    {
        get
        {
            return this.color;
        }
        set
        {
            this.color = value;
        }
    }

    public Card()         // default constructor
    {
        this.value = 0;
        this.color = 0;
    }

    public Card(string cardStr)         // constructor with parameters
    {
        switch (cardStr[0])
        {
            case 'T': this.value = 10; break;
            case 'J': this.value = 11; break;
            case 'Q': this.value = 12; break;
            case 'K': this.value = 13; break;
            case 'A': this.value = 14; break;
            default: this.value = int.Parse(cardStr[0].ToString()); break;
        }
        switch (cardStr[1])
        {
            case 'h': this.color = 3; break;
            case 'd': this.color = 4; break;
            case 'c': this.color = 5; break;
            case 's': this.color = 6; break;
            default: this.color = 0; break;
        }
    }

    public static void DrawCardUp(int x, int y, Card card)
    {
        // x,y - position of top left point of card on console
        // Card.Value - 2->2, 3->3, ... 10->10, 11-J, 12-Q, 13-K, 14-A 
        // Card.Color - 3->'h'->♥, 4->'d'->♦, 5->'c'->♣, 6->'s'->♠

        int origX = x;
        int origY = y;
        Console.SetCursorPosition(x, y);
        int cardWidth = 11;
        int cardLength = 7;
        char[] ch = new char[255];
        for (byte i = 0; i < byte.MaxValue; i++)
        {
            ch[i] = Encoding.GetEncoding(437).GetChars(new byte[] { i })[0];
        }

        // draw the frame
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;

        Console.Write("{0}{1}{2}", ch[201], new string(ch[205], cardWidth), ch[187]);
        Console.SetCursorPosition(x, ++y);
        for (int i = 0; i < cardLength; i++)
        {
            Console.Write("{0}{1}{2}", ch[186], new string(' ', cardWidth), ch[186]);
            Console.SetCursorPosition(x, ++y);
        }
        Console.Write("{0}{1}{2}", ch[200], new string(ch[205], cardWidth), ch[188]);

        // draw card value and color
        string whatCard = "";
        if (card.Value >= 2 && card.Value <= 14)
        {
            switch (card.Value)
            {
                case 10: whatCard = "T"; break;
                case 11: whatCard = "J"; break;
                case 12: whatCard = "Q"; break;
                case 13: whatCard = "K"; break;
                case 14: whatCard = "A"; break;
                default: whatCard = card.Value.ToString();
                    break;
            }
        }
        else whatCard = "?";  // default

        Console.ForegroundColor = (card.Color == 3 || card.Color == 4) ? ConsoleColor.Red : ConsoleColor.Black;
        x = origX + 1;
        y = origY + 1;
        Console.SetCursorPosition(x, y);
        Console.Write("{0}{1}", whatCard, ch[card.Color]);
        Console.SetCursorPosition(x + 5, y + 3);
        Console.Write(ch[card.Color]);
        Console.SetCursorPosition(origX + cardWidth - 1, origY + cardLength);
        Console.Write("{0}{1}", whatCard, ch[card.Color]);
        Console.ResetColor();
    }

    public static void DrawCardBack(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        int cardWidth = 11;
        int cardLength = 7;
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Black;
        char[] ch = new char[255];
        for (byte i = 0; i < byte.MaxValue; i++)
        {
            ch[i] = Encoding.GetEncoding(437).GetChars(new byte[] { i })[0];
        }
        char fill = ch[176];

        Console.Write("{0}{1}{2}", ch[201], new string(ch[205], cardWidth), ch[187]);
        Console.SetCursorPosition(x, ++y);
        for (int i = 0; i < cardLength; i++)
        {
            Console.Write("{0}{1}{2}{1}{0}", ch[186], ch[0], new string(fill, cardWidth - 2));
            Console.SetCursorPosition(x, ++y);
        }
        Console.Write("{0}{1}{2}", ch[200], new string(ch[205], cardWidth), ch[188]);
        Console.ResetColor();
    }

    public static void DrawCardPile(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        int cardWidth = 11;
        int cardLength = 7;
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Black;
        char[] ch = new char[255];
        for (byte i = 0; i < byte.MaxValue; i++)
        {
            ch[i] = Encoding.GetEncoding(437).GetChars(new byte[] { i })[0];
        }
        char fill = ch[176];

        Console.Write("{0}{1}{2}", ch[201], new string(ch[205], cardWidth), ch[187]);
        Console.SetCursorPosition(x, ++y);
        Console.Write("{0}{1}{2}{1}{3}{4}", ch[186], ch[0], new string(fill, cardWidth - 2), ch[204], ch[187]);
        Console.SetCursorPosition(x, ++y);
        Console.Write("{0}{1}{2}{1}{0}{3}{4}", ch[186], ch[0], new string(fill, cardWidth - 2), ch[204], ch[187]);
        Console.SetCursorPosition(x, ++y);

        for (int i = 0; i < cardLength - 2; i++)
        {
            Console.Write("{0}{1}{2}{1}{0}{0}{0}", ch[186], ch[0], new string(fill, cardWidth - 2));
            Console.SetCursorPosition(x, ++y);
        }
        Console.Write("{0}{1}{2}{3}{4}{4}", ch[200], ch[203], new string(ch[205], cardWidth - 1), ch[188], ch[186]);
        Console.SetCursorPosition(++x, ++y);
        Console.Write("{0}{1}{2}{3}{4}", ch[200], ch[203], new string(ch[205], cardWidth - 1), ch[188], ch[186]);
        Console.SetCursorPosition(++x, ++y);
        Console.Write("{0}{1}{2}", ch[200], new string(ch[205], cardWidth), ch[188]);
        Console.ResetColor();
    }

    //public static void EraseCard(int x, int y)
    //{
    //    Console.SetCursorPosition(x, y);
    //    int cardWidth = 11;
    //    int cardLength = 7;
    //    Console.BackgroundColor = ConsoleColor.Black;
    //    Console.ForegroundColor = ConsoleColor.Black;
    //    for (int i = 0; i < cardLength + 2; i++)
    //    {
    //        Console.Write(new string(' ', cardWidth + 2));
    //        Console.SetCursorPosition(x, ++y);
    //    }
    //    Console.ResetColor();
    //}

    //public static void EraseCardPile(int x, int y)
    //{
    //    Console.SetCursorPosition(x, y);
    //    int cardWidth = 11;
    //    int cardLength = 7;
    //    Console.BackgroundColor = ConsoleColor.Black;
    //    Console.ForegroundColor = ConsoleColor.Black;
    //    for (int i = 0; i < cardLength + 4; i++)
    //    {
    //        Console.Write(new string(' ', cardWidth + 4));
    //        Console.SetCursorPosition(x, ++y);
    //    }
    //    Console.ResetColor();
    //}

    public static void BlinkCard(int x, int y, Card card)
    {
        int origX = x;
        int origY = y;

        Console.SetCursorPosition(x, y);
        int cardWidth = 11;
        int cardLength = 7;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        char[] ch = new char[255];
        for (byte i = 0; i < byte.MaxValue; i++)
        {
            ch[i] = Encoding.GetEncoding(437).GetChars(new byte[] { i })[0];
        }
        char fill = ' ';

        Console.Write("{0}{1}{2}", ch[201], new string(ch[205], cardWidth), ch[187]);
        Console.SetCursorPosition(x, ++y);
        for (int i = 0; i < cardLength; i++)
        {
            Console.Write("{0}{1}{2}{1}{0}", ch[186], ch[0], new string(fill, cardWidth - 2));
            Console.SetCursorPosition(x, ++y);
        }
        Console.Write("{0}{1}{2}", ch[200], new string(ch[205], cardWidth), ch[188]);
        Console.ResetColor();
        System.Threading.Thread.Sleep(200);
        DrawCardUp(origX, origY, card);
    }

    //public static void AnimateText(int x, int y)
    //{
    //    int windWidth = 40;
    //    //int winHeigth = 5;

    //    char[] ch = new char[255];
    //    for (byte i = 0; i < byte.MaxValue; i++)
    //    {
    //        ch[i] = Encoding.GetEncoding(437).GetChars(new byte[] { i })[0];
    //    }

    //    for (int i = 0; i < windWidth; i += 2)
    //    {
    //        Console.SetCursorPosition(x, y);
    //        Console.Write("{0}{1}{2}", ch[201], new string(ch[205], i), ch[187]);
    //        Console.SetCursorPosition(x, ++y);
    //        Console.Write("{0}{1}{0}", ch[186], new string(' ', i));
    //        Console.SetCursorPosition(x, ++y);
    //        Console.Write("{0}{1}{0}", ch[186], new string(' ', i));
    //        Console.SetCursorPosition(x, ++y);
    //        Console.Write("{0}{1}{0}", ch[186], new string(' ', i));
    //        Console.SetCursorPosition(x, ++y);
    //        Console.Write("{0}{1}{2}", ch[200], new string(ch[205], i), ch[188]);
    //        System.Threading.Thread.Sleep(30);
    //        x--;
    //        y -= 4;
    //    }
    //    Console.SetCursorPosition(x + 5, y + 2);
    //    Console.BackgroundColor = ConsoleColor.Red;
    //    Console.ForegroundColor = ConsoleColor.Green;

    //    int posX = x + 5;
    //    for (int i = 0; i <= 38; i++)
    //    {
    //        Console.SetCursorPosition(posX, y + 2);
    //        Console.Write("Prepare for QUIZ!");
    //        System.Threading.Thread.Sleep(50);
    //        Console.ResetColor();
    //        Console.SetCursorPosition(posX, y + 2);
    //        Console.Write("                 ");
    //        Console.BackgroundColor = ConsoleColor.Red;
    //        Console.ForegroundColor = ConsoleColor.Green;
    //        if (i < 15 || i > 30)
    //        {
    //            posX++;
    //        }
    //        else posX--;
    //        if (i == 38)
    //        {
    //            Console.SetCursorPosition(x + 13, y + 2);
    //            Console.Write("Prepare for QUIZ!");
    //        }
    //    }
    //    Console.ResetColor();
    //}

}


using System;

class PrintDeck
{
    static void Main()
    {
        string[] cards = new string[] {"Clubs", "Diamonds", "Hears", "Spades" };
        string[] numbers = new string[] {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

        for (int i = 0; i < cards.Length; i++)
        {
            switch (i)
            {
                case 0:
                    Console.WriteLine(cards[i]);
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        Console.Write(numbers[j] + " ");
                    }
                    Console.WriteLine();
                    break;
                case 1:
                    Console.WriteLine(cards[i]);
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        Console.Write(numbers[j] + " ");
                    }
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine(cards[i]);
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        Console.Write(numbers[j] + " ");
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine(cards[i]);
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        Console.Write(numbers[j] + " ");
                    }
                    Console.WriteLine();
                    break;
            }
        }
    }
}


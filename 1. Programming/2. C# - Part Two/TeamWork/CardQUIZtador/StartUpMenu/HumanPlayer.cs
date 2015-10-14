using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUpMenu
{
    public class HumanPlayer
    {
        private static int points;
        private static int cardValue;
        private static int choice;

        public static int Points
        {
            get
            {
                return points;
            }
            set
            {
                points = value;
            }
        }
        public static int CardValue
        {
            get
            {
                return cardValue;
            }
            set
            {
                cardValue = value;
            }
        }
        public static int Choice
        {
            get
            {
                return choice;
            }
            set
            {
                choice = value;
            }
        }
    }
}

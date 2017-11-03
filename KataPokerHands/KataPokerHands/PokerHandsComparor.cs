using System.Collections.Generic;

namespace KataPokerHands
{
    public class PokerHandsComparor
    {
        public string compare(string black, string white)
        {
            var cardNameMap = new Dictionary<string, string>()
            {
                {"A","Ace" },
                {"K", "King" },
                {"Q","Queen" },
                {"J", "Jack" }
            };
            var cardValueMap = new Dictionary<string, int>()
            {
                {"A", 14 },
                {"K",13 },
                {"Q",12 },
                {"J",11 },
                {"10",10 },
                {"9",9 },
                {"8",8 },
                {"7",7 },
                {"6",6 },
                {"5",5 },
                {"4",4 },
                {"3",3 },
                {"2",2 }
            };
            if (white.Length == 0 && black.Length == 0)
            {
                return "Tie";
            }
            var blackList = black.Split(' ');
            var whiteList = white.Split(' ');
            if (cardValueMap[blackList[4][0].ToString()] > cardValueMap[whiteList[4][0].ToString()])
            {
                return "Black wins. - with high card: " + cardNameMap[blackList[4][0].ToString()];
            }
            else
            {
                return "White wins. - with high card: " + cardNameMap[whiteList[4][0].ToString()];
            }
            return "";
        }
    }
}
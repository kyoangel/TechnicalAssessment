namespace KataPokerHands
{
    public class PokerHandsComparor
    {
        public string compare(string black, string white)
        {
            if (white.Contains("A"))
            {
                return "White wins. - with high card: Ace";
            }
            if (white.Contains("K"))
            {
                return "White wins. - with high card: King";
            }
            return "Tie";
        }
    }
}
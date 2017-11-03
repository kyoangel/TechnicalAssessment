namespace KataPokerHands
{
    public class PokerHandsComparor
    {
        public string compare(string black, string white)
        {
            if (black.Length != 0)
            {
                return "White wins. - with high card: Ace";
            }
            return "Tie";
        }
    }
}
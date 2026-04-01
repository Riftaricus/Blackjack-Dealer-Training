namespace Blackjack_Dealer_Training.GameLogic
{
    public class Deck
    {
        Card[] cards { get; set; }

        public int cardsLeft { get; set; }

        private static Random rng = new Random();

        public Deck(int deckAmount = 1)
        {
            cards = new Card[deckAmount*52];
            cardsLeft = deckAmount * 52;
            for (int i = 0; i < 13; i++) {
                for (int j = 0; j < 4; j++) {
                    for (int k = 0; k < deckAmount; k++) {
                        cards[i*4*deckAmount + j*deckAmount + k] = new Card((Rank)(i+1), (Suit)j);
                    }
                }
            }
        }

        public void shuffle()
        {
            int n = cards.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

        public Card draw()
        {
            int length = cards.Length;
            Card selectedCard;
            try
            {
                selectedCard = cards[length - 1];
            } catch(IndexOutOfRangeException)
            {
                return null;
            }
            cards = cards.Take(cards.Count() - 1).ToArray();

            cardsLeft--;

            return selectedCard;
        }

    }
}

namespace Blackjack_Dealer_Training.GameLogic
{
    public class Hand
    {
        bool canPlay { get; set; }

        public List<Card> cards { get; set; }
        bool hasPassed;

        public Hand()
        {
            canPlay = true;
            cards = new List<Card>();
            hasPassed = false;
        }

        public int getValue()
        {
            int value = 0;
            int aceAmount = 0;

            foreach (Card card in cards)
            {
                value += card.value;
                if (value == 11)
                {
                    aceAmount++;
                }
            }
            while (value > 21 && aceAmount > 0)
            {
                value -= 10;
                aceAmount--;
            }

            if (value > 21) {
                return 0;
            }

            return value;
        }

        public void addCard(Card card)
        {
            cards.Add(card);
        }

        public void hit()
        {
            Card? drawnCard = GameController.table?.deck.draw();

            if (drawnCard != null)
            {
                addCard(drawnCard);
            } 
        }

        public void stand()
        {
            hasPassed = true;
        }

    }
}

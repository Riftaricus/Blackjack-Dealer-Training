using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack_Dealer_Training.GameLogic
{
    enum TableState
    {
        WaitingForPlayers,
        DealingCards,
        PlayerTurns,
        DealerTurn,
        RoundOver
    }

    public class Table
    {
        public Deck deck { get; private set; }

        public List<Character> players;

        TableState tableState { set; get; }

        int totalChips;

        int totalPlayers;

        public Table()
        {
            deck = new Deck(5);
            players = new List<Character>();
            totalChips = 0;
            totalPlayers = 0;
            tableState = TableState.WaitingForPlayers;
        }

        public void shuffleDeck()
        {
            deck.shuffle();
        }

        public Card drawCard()
        {
            return deck.draw();
        }

        public void addChips(int chips)
        {
            totalChips += chips;
        }

        public void stopGame()
        {
            players.Clear();
            totalPlayers = 0;
            totalChips = 0;
            tableState = TableState.RoundOver;
        }

        public void addPlayer(Character player)
        {
            if (tableState != TableState.WaitingForPlayers)
            {
                throw new InvalidOperationException("Cannot add players after the game has started.");
            }
            players.Add(player);
            totalPlayers++;
            //totalChips += player.Chips;
        }
        public void addPlayers(List<Player> players)
        {
            if (tableState != TableState.WaitingForPlayers)
            {
                throw new InvalidOperationException("Cannot add players after the game has started.");
            }

            foreach (Player player in players)
            {
                players.Add(player);
            }
            totalPlayers++;
        }
    }
}

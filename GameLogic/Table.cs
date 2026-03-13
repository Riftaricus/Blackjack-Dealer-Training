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
        Shoe shoe;

        List<Player> players;

        TableState tableState;

        int totalChips;

        int totalPlayers;

        public Table()
        {
            shoe = new Shoe();
            players = new List<Player>();
            totalChips = 0;
            totalPlayers = 0;
            tableState = TableState.WaitingForPlayers;
        }

        public void stopGame()
        {
            players.Clear();
            totalPlayers = 0;
            totalChips = 0;
            tableState = TableState.RoundOver;
        }

        public void addPlayer(Player player)
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
            //totalChips += player.Chips;
        }

        public void startGame()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Isabella Da Silva
// First Game

namespace GuessingGame
{
    public class Player
    {
        public string Name { get; private set; }
        public int GamesPlayed { get; private set; }

        public Player(string name)
        {
            Name = name;
        }

        public void SetName(string newName)
        {
            Name = newName;
        }

        public void IncrementGamesPlayed()
        {
            GamesPlayed++;
        }

    }
}


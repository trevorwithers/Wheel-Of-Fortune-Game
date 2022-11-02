using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Trevor Withers
/// <summary>
/// Tracks player name and score
/// </summary>

namespace Assignment2_TrevorWithers
{
    [Serializable]
    internal class Player
    {
        public string PlayerName { get; set; }
        public int PlayerScore { get; set; }
        public int NumOfWins { get; set; }
        public int NumOfLosses { get; set; }

        public Player(string initialPlayerName)
        {
            PlayerName = initialPlayerName;
            PlayerScore = 0;
            NumOfWins = 0;
            NumOfLosses = 0;
        }
    }
}

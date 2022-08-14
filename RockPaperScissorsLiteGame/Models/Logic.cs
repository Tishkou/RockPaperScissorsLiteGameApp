using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLiteGame.Models
{
    public class Logic
    {
        public string UserInput { get; set; }
        public string Opponent { get; set; }


        public int playerWinnerCounter { get; set; }

        public int opponentWinnerCounter { get; set; }

        public int drawCounter { get; set; }


    }
}

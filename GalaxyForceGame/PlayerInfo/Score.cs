using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyForceGame.PlayerInfo
{
    public class Score
    {
        public int TotalScore { get; set; }

        public int AmountOfKills { get; set; }

        public SpriteFont Font { get; set; }
        public Score()
        {
            AmountOfKills = 0;
            TotalScore = 0;
        }
    }
}

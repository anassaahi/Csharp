using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameincsharp
{
    internal class Player
    {
        public char playerchar;
        public int pX;
        public int pY;
        public Player(char pcharacter, int px, int py)
        {
            this.playerchar = pcharacter;
            this.pX = px;
            this.pY = py;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class TablePosition : Card
    {
        public bool temcard = false;
        public MonsterCard cartaalocada;
        public TablePosition(int x, int y)
        {
            this.Enabled = false;
            this.Location = new System.Drawing.Point(x, y);
            this.BorderStyle = BorderStyle.Fixed3D;
            this.Image = null;
        }        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class TablePosition : Card
    {
        public TablePosition(int x, int y)
        {
            this.Location = new System.Drawing.Point(x, y); 
            //this.contorno = azul
        }

        
        
    }
}

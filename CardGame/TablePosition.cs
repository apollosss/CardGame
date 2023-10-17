using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class TablePosition : Card
    {
        public TablePosition(int x, int y)//coordenadas x e y para a posição da mesa de cartas
        {
            this.Location = new System.Drawing.Point(x, y); // Define a localização da posição da mesa nas coordenadas especificadas x e y.
        }

        // Event handler for the click event
        
    }
}

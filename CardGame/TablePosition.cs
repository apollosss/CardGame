using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class TablePosition : PictureBox
    {
        public TablePosition(int x, int y) //coordenadas x e y para a posição da mesa de cartas
        {
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Location = new System.Drawing.Point(x, y); // Define a localização da posição da mesa nas coordenadas especificadas x e y.
            this.Size = new System.Drawing.Size(140, 200);
            this.TabIndex = 0;
            this.TabStop = false;
        }

        // Event handler for the click event
        protected override void OnClick(EventArgs e)
        {
            MessageBox.Show("Cliquei numa tablePosition");
        }
    }
}

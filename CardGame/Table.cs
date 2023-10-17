using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }

        private void Table_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            List<Card> cartas_DoBD = new List<Card>(); // Excluir isso dps pelas cartas vindas do bd
            Deck deck = new Deck(cartas_DoBD); // add as cartas do bd pro deck
            for(int i = 0; i < 100; i++) deck.cards.Add(new MonsterCard(1,"as",2,"asd","asd",1,1,1,"ads")); 
            
            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    TablePosition tablePosition = new TablePosition(j * 162, i * 600);
                    Card carta_prov = deck.cards[0];
                    carta_prov = tablePosition;
                    this.Controls.Add(carta_prov);
                }
            }
            
        }
    }
}

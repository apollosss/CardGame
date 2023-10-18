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
            Deck deckMonster = new Deck();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    TablePosition tablePosition = new TablePosition(j * 90 + 500, i * 600);
                    MonsterCard carta_prov = deckMonster.lista_cartas_monstros[j + (i*6)];
                    carta_prov.Location = tablePosition.Location;
                    carta_prov.MouseEnter += PassarMouseNaCarta;
                    carta_prov.MouseLeave += TirarMouseDaCarta;
                    this.Controls.Add(carta_prov);
                }
            }
            
        }
        private void PassarMouseNaCarta(object sender, EventArgs e)
        {
            Control controleselec = (Control)sender;
            MonsterCard cartaselec = (MonsterCard)controleselec;
            cartaselec.Location = new Point(cartaselec.Location.X, cartaselec.Location.Y - 10);
            cartaselec.BringToFront();
            label1.Text = $"id: {cartaselec.GetId()} \n" +
                $"nome: {cartaselec.GetNome()} \n" +
                $"estrela: {cartaselec.GetEstrela()} \n" +
                $"elemento: {cartaselec.GetElemento()} \n" +
                $"path: {cartaselec.GetPath()} \n" +
                $"vida: {cartaselec.GetVida()} \n" +
                $"dano: {cartaselec.GetDano()} \n" +
                $"escudo: {cartaselec.GetEscudo()} \n" +
                $"raça: {cartaselec.GetRaca()}";
        }
        private void TirarMouseDaCarta(object sender, EventArgs e)
        {
            Control controleselec = (Control)sender;
            MonsterCard cartaselec = (MonsterCard)controleselec;
            cartaselec.Location = new Point(cartaselec.Location.X, cartaselec.Location.Y + 10);
        }
    }
}

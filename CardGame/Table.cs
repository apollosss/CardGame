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
        Deck deckMonster = new Deck();
        TablePosition tbSD = new TablePosition(915, 234);
        TablePosition tbSE = new TablePosition(500, 234);
        private void Table_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Controls.Add(tbSD);
            this.Controls.Add(tbSE);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    MonsterCard carta_prov = deckMonster.lista_cartas_monstros[j + (i * 6)];
                    carta_prov.Location = new Point(j * 90 + 600, i * 630);
                    carta_prov.MouseEnter += PassarMouseNaCarta;
                    carta_prov.MouseLeave += TirarMouseDaCarta;
                    carta_prov.MouseCaptureChanged += LocalPosition;
                    this.Controls.Add(carta_prov);
                }
            }
            for (int i = 0; i <= deckMonster.lista_cartas_monstros.Count - 1; i++)
                label2.Text += "\n" + deckMonster.lista_cartas_monstros[i].GetNome();
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
            label3.Text = cartaselec.Location.ToString();
        }
        private void LocalPosition(object sender, EventArgs e)
        {
            if(tbSD.temcard && tbSE.temcard)
            {
                GameLogic.Ataque(tbSD.cartaalocada, tbSE.cartaalocada);
            }
            Control controleselec = (Control)sender;
            MonsterCard cartaselec = controleselec as MonsterCard;
            Point posinicial = cartaselec.Location;
            foreach (Control control in this.Controls)
            {
                if(control is TablePosition)
                {
                    TablePosition tb = (TablePosition)control;
                    if (cartaselec.Bounds.IntersectsWith(tb.Bounds) && !tb.temcard)
                    {
                        cartaselec.Location = control.Location;
                        cartaselec.BringToFront();
                        tb.temcard = true;
                        tb.cartaalocada = cartaselec;
                        break;
                    }
                    else
                    {
                    }
                }   
            }
        }
        private void TirarMouseDaCarta(object sender, EventArgs e)
        {
            Control controleselec = (Control)sender;
            MonsterCard cartaselec = (MonsterCard)controleselec;
            cartaselec.Location = new Point(cartaselec.Location.X, cartaselec.Location.Y + 10);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

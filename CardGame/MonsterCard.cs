using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class MonsterCard : Card
    {
        private int vida;
        private int dano;
        private int escudo;
        private string raca;
        private bool vivo = true;

        public MonsterCard(int id, string nome, int estrela, string elemento, int vida, int dano, int escudo, string raca)
        {
            SetId(id);
            SetNome(nome);
            SetEstrela(estrela);
            SetElemento(elemento);
            SetVida(vida);
            SetDano(dano);
            SetEscudo(escudo);
            SetRaca(raca);
            SetPath();
            this.pathVirada = @"..\..\..\Imagens\cartaMonstro_Virada.gif";
        }
        public void SetVida(int vida){this.vida = vida; }
        public void SetDano(int dano){this.dano = dano;}
        public void SetEscudo(int escudo){this.escudo = escudo;}
        public void SetRaca(string raca){ this.raca = raca; }
        public void SetVivo(bool vivo){this.vivo = vivo;}
        
        public int GetVida() { return this.vida; }
        public int GetDano() { return this.dano; }
        public int GetEscudo() { return this.escudo; }
        public string GetRaca() { return this.raca; }
        public bool GetVivo() { return this.vivo; }
    }
}

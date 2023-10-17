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
        private string raca = "";
        private bool vivo = true;

        public MonsterCard(int id, string nome, int estrela, string elemento, string path,int vida, int dano, int escudo, string raca)
        {
            SetId(id);
            SetNome(nome);
            SetEstrela(estrela);
            SetElemento(elemento);
            SetPath(path);
            SetVida(vida);
            SetDano(dano);
            SetEscudo(escudo);
            SetRaca(raca);
            this.Image = Image.FromFile(@"C:\Users\felli\Downloads\valquiria-clash-royale.png");

        }

        public void SetId(int id) { this.id = id; }
        public void SetNome(string nome) { this.nome = nome; }
        public void SetEstrela(int estrela) { this.estrela = estrela; }
        public void SetElemento(string elemento) { this.elemento = elemento; }
        public void SetPath(string path) { this.path = path; }
        public void SetVida(int vida)
        {
            if (this.vida - vida > 0)
            {
                this.vida = vida;
            }
            else
                vivo = false;
        }
        public void SetDano(int dano){this.dano = dano;}
        public void SetEscudo(int escudo){this.escudo = escudo;}
        public void SetRaca(string raca){ this.raca = raca; }
        public void SetVivo(bool vivo){this.vivo = vivo;}
        

        public int GetId() { return this.id; }
        public string GetNome() { return this.nome; }
        public int GetEstrela() { return this.estrela; }
        public string GetElemento() { return this.elemento; }
        public string GetPath() { return this.path; }
        public int GetVida() { return this.vida; }
        public int GetDano() { return this.dano; }
        public int GetEscudo() { return this.escudo; }
        public string GetRaca() { return this.raca; }
        public bool GetVivo() { return this.vivo; }
    }
}

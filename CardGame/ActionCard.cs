using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class ActionCard : Card
    {
        private string tipo;
        private int valor;
        private string descricao;

        public ActionCard(int id, string nome, int estrela, string elemento, string path, string tipo, int valor, string descricao)
        {
            SetId(id);
            SetNome(nome);
            SetEstrela(estrela);
            SetElemento(elemento);
            SetPath(path);
            SetTipo(tipo);
            SetValor(valor);
            SetDesc(descricao);
        }
        public void SetTipo(string tipo){ this.tipo = tipo; }
        public void SetValor(int valor) { this.valor = valor; }
        public void SetDesc(string descricao) { this.descricao = descricao; }

        public string GetTipo() { return this.tipo; }
        public int GetValor() { return this.valor; }
        public string GetDesc() { return this.descricao; }


    }
}

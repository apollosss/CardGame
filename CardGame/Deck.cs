using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Deck
    {
        public List<Card> cards = new List<Card>();

        public Deck(List<Card> cards)
        {
            this.cards = cards;
        }

        public void Shuffle()
        {
            // Método que irá embaralhar a lista cards
            // Procurar na internet "como embaralhar uma lista ou vetor em C#"
            // ou desenvolver própria lógica
        }
    }
}

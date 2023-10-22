using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class GameLogic
    {
        public static void Ataque(MonsterCard atacante,MonsterCard atacado)
        {
            if (atacante.GetDano() > atacado.GetDano())
                atacado.Image = null;
            else
                atacante.Image = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Usuario
    {
        private int id;
        private string nickname;
        private string senha;
        private int nivel;

        public Usuario(int id, string nickname, string senha, int nivel)
        {
            SetId(id);
            SetNickname(nickname);
            SetSenha(senha);
            SetNivel(nivel);

        }
        public void SetId(int id) { this.id = id; }

        public void SetNickname(string nickname) { this.nickname = nickname; }
        public void SetSenha(string senha) { this.senha = senha; }
        public void SetNivel(int nivel) { this.nivel = nivel; }

        public int GetId() { return this.id; }
        public string GetNickname() { return this.nickname; }
        public string GetSenha() { return this.senha; }

        public int GetNivel() { return this.nivel; }

    }
}

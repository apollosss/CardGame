﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Deck
    {
        public List<MonsterCard> lista_cartas_monstros = new List<MonsterCard>();
        public List<ActionCard> lista_cartas_acao = new List<ActionCard>();
        public List<Usuario> lista_usuarios = new List<Usuario>();

        public Deck()
        {
            Preencher_parametros();
        }

        public void Shuffle()
        {
            // Método que irá embaralhar a lista cards
            // Procurar na internet "como embaralhar uma lista ou vetor em C#"
            // ou desenvolver própria lógica

        }

        DataTable tabela_monstro = ConsultarBD.Consultas("SELECT c.*,cm.* FROM carta_monstro cm,cartas c WHERE cm.id_carta=c.id_carta");

        DataTable tabela_acao = ConsultarBD.Consultas("SELECT c.*,ca.* FROM carta_acao ca,cartas c WHERE ca.id_carta=c.id_carta");

        DataTable tabela_usuario = ConsultarBD.Consultas("SELECT * FROM usuario");



        public void Preencher_parametros()
        {

           

            foreach (DataRow row in tabela_monstro.Rows)//Preenchendo os campos das cartas monstro e guardando
                                                        //cada carta em uma lista de cartas de monstro
            {
                string nome = Convert.ToString(row["nome_carta"]);
                int id = Convert.ToInt32(row["id_carta"]);
                int estrela = Convert.ToInt32(row["estrela"]);
                string elemento = Convert.ToString(row["elemento"]);
                string path = Convert.ToString(row["link_img_carta"]);
                int vida = Convert.ToInt32(row["vida_monstro"]);
                int dano = Convert.ToInt32(row["dano_monstro"]);
                int escudo = Convert.ToInt32(row["escudo_monstro"]);
                string raca = Convert.ToString(row["raca"]);

                MonsterCard m1 = new MonsterCard(id, nome, estrela, elemento, path, vida, dano, escudo, raca);

                lista_cartas_monstros.Add(m1);

            }

            foreach (DataRow row in tabela_acao.Rows)//Preenchendo os campos das cartas de ação e guardando
                                                     //cada carta em uma lista de cartas de ação
            {
                string nome = Convert.ToString(row["nome_carta"]);
                int id = Convert.ToInt32(row["id_carta"]);
                int estrela = Convert.ToInt32(row["estrela"]);
                string elemento = Convert.ToString(row["elemento"]);
                string path = Convert.ToString(row["link_img_carta"]);
                string tipo = Convert.ToString(row["tipo"]);
                int valor = Convert.ToInt32(row["valor_acao"]);
                string descricao = Convert.ToString(row["desc_acao"]);

                ActionCard a1 = new ActionCard(id, nome, estrela, elemento, path, tipo, valor, descricao);
                lista_cartas_acao.Add(a1);

            }

            foreach (DataRow row in tabela_usuario.Rows)//Preenchendo os campos das cartas de ação e guardando
                                                        //cada carta em uma lista de cartas de ação
            {
                int id = Convert.ToInt32(row["id_usuario"]);
                string nickname = Convert.ToString(row["nickname"]);
                string senha = Convert.ToString(row["senha"]);
                int nivel = Convert.ToInt32(row["nivel"]);

                Usuario u1 = new Usuario(id, nickname, senha, nivel);
                lista_usuarios.Add(u1);

            }


        }


    }
}

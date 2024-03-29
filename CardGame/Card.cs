﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Card : System.Windows.Forms.PictureBox
    {
        protected int id;
        protected string nome;
        protected int estrela;
        protected string elemento;
        protected string path = @"..\..\..\Imagens\Leviata.gif";
        protected string pathVirada;

        public bool faceUp = false;//indica se a carta está voltada para cima ou não

        public bool isDragging = false;// indica se a carta está atualmente sendo arrastada (dragged) pelo jogador
                                       // Quando ela for arratada,devemos atualizar sua posição.


        private Point offset;

        //variável será usada para rastrear a diferença entre a posição do cursor do mouse e a
        //posição da carta quando o jogador começa a arrastar a carta. 


        public Card()
        {
            DefaultAttributes();

        }
        public void SetId(int id) { this.id = id; }
        public void SetNome(string nome) { this.nome = nome; }
        public void SetEstrela(int estrela) { this.estrela = estrela; }
        public void SetElemento(string elemento) { this.elemento = elemento; }
        public void SetPath() { this.path += nome + ".gif"; }

        public int GetId() { return this.id; }
        public string GetNome() { return this.nome; }
        public int GetEstrela() { return this.estrela; }
        public string GetElemento() { return this.elemento; }
        public string GetPath() { return this.path; }
        protected void DefaultAttributes()
        {
            FlipCard();
            this.Size = new System.Drawing.Size(140, 200);
            this.TabIndex = 0;
            this.TabStop = false;

            // Associação dos métodos que irão tratar o arrastar e soltar das cartas
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MouseDown += Card_MouseDown;
            this.MouseMove += Card_MouseMove;
            this.MouseUp += Card_MouseUp;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Bounds = new Rectangle(
            this.Bounds.X + 10,  // Aumenta a posição X
            this.Bounds.Y + 10,  // Aumenta a posição Y
            this.Bounds.Width - 20,  // Reduz a largura em 20 pixels (10 à esquerda e 10 à direita)
            this.Bounds.Height - 20);
        }
        protected override void OnDoubleClick(EventArgs e)// Quando o usuário realiza um clique duplo em uma carta,
                                                          // esse método será
        {
            FlipCard();
        }

        private void FlipCard()//Altera a carta de acordo com sua situação,para cima ou para baixo
        {
            //feceup por default é false,quando esse metodo(Flipcarde) é chamado,esse valor é invertido,ou seja,vira true,
            //caso esse metodo seja chamado novamente,faceup será convertido para false,virando a carta novamente

            //numero impar de vezes que a função foi chamada= carta virada para cima
            //numero par de vezes que a função foi chamada = carta virada para baixo

            faceUp = !faceUp;

            if (faceUp)
            {
                this.Image = Image.FromFile(path);
            }
            else
            {
                this.Image = Image.FromFile(pathVirada);
            }

        }

        private void Card_MouseDown(object sender, MouseEventArgs e) //responde ao evento de pressionar
                                                                     //o botão do mouse enquanto o cursor do mouse está sobre a carta.
        {
            isDragging = true;//Coloca como true a variavel que verifica se a carta está sendo arrastada 
            offset = e.Location;
        }

        private void Card_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)//verificar se o usuario está movendo a carta
                           // Se está,a ação de mover a carta deve ser executada.
            {
                Point newLocation = this.Location;
                //Cria uma nova variável newLocation que é inicializada com a localização atual da carta.
                //Ela armazena as coordenadas X e Y atuais da posição da carta.
                newLocation.X += e.X - offset.X;
                newLocation.Y += e.Y - offset.Y;

                //atualizam a posição da carta com base no movimento do cursor do mouse
                //offset.X e offset.Y representam a diferença entre a posição do cursor do mouse e a posição da carta no momento em que o arrastar começou.
                //Portanto, essas linhas estão calculando a nova posição da carta com base no movimento do cursor e ajustando a posição da carta de acordo.

                this.Location = newLocation;
            }
        }

        private void Card_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        protected override void OnClick(EventArgs e)
        {

        }
    }
}

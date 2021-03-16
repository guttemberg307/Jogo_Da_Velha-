using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        bool xis = true;  // se for true é a vez do jogador X, caso nao sera o jogador Zero.

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // metodo criado para tratar o evendo de click
            b11.Click += new EventHandler(BClick);
            b12.Click += new EventHandler(BClick);
            b13.Click += new EventHandler(BClick);
            b21.Click += new EventHandler(BClick);
            b22.Click += new EventHandler(BClick);
            b23.Click += new EventHandler(BClick);
            b31.Click += new EventHandler(BClick);
            b32.Click += new EventHandler(BClick);
            b33.Click += new EventHandler(BClick);

            foreach (Control item in this.Controls)// percorre a lista de todos os controles 
            {
                if (item is Button) // se o item for um botao faça  
                {
                    item.TabStop = false; // desliga a propriedade TabStop, para que o jogador nao seja influenciado a apertar 
                                          // o proximo botão 
                }

            }


        }

        private void BClick(object sender, EventArgs e)
        {
            ((Button)sender).Text = this.xis ? "X" : "O";// se o texto X for true ou vise e versa 
            ((Button)sender).Enabled = false;//
            verificarGanhador();


            xis = !xis; // inverte o X pra falar quem é a vez do proximo jogador 


            button1.Text = string.Format("{0}, é a sua vez", this.xis ? "X" : "O"); // diz qual a VEZ do jogador referente ao simbolo escolhido

        }

        private void verificarGanhador()
        {



            if (b11.Text != String.Empty && b11.Text == b12.Text && b12.Text == b13.Text || //linha  1 // compara os botões das linhas se os 3 sao iguais ou diferentes de vazio 
               b21.Text != String.Empty && b21.Text == b22.Text && b22.Text == b23.Text || //linha 2
               b31.Text != String.Empty && b31.Text == b32.Text && b32.Text == b33.Text ||//linha  3

               b11.Text != String.Empty && b11.Text == b21.Text && b21.Text == b31.Text || //coluna 1// o mesmo teste para as 3 colunas 
               b12.Text != String.Empty && b12.Text == b22.Text && b22.Text == b32.Text ||//coluna 2
               b13.Text != String.Empty && b13.Text == b23.Text && b23.Text == b33.Text ||//coluna 3


               b11.Text != String.Empty && b11.Text == b22.Text && b22.Text == b33.Text || // diagonal esquerta pra direita // e tambem as diagonais 
               b13.Text != String.Empty && b13.Text == b22.Text && b22.Text == b31.Text)// diagonal direita pra esquerda      

            {
                MessageBox.Show(string.Format("O ganhador é o [{0}]", xis ? "X" : "O"), " Voce é o Vencedor", // da uma messagem referindo ao jogador que ganhou
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Reiniciar();
            }
            else
            {
                verificarEmpate(); // função que retorna empate 
            }


        }
        private void verificarEmpate()
        {

            bool todoDesabilitados = true;
            bool x = false;

            foreach (Control item in this.Controls)// percorre todo os controles 
            {
                if (item is Button && item.Enabled) // se o item for abilitado e for um botao 
                {
                    todoDesabilitados = false; // retorne falso 
                    break;
                   

                }
                

            }

            if(x){
                MessageBox.Show(String.Format("deu empate"), "OPs !!!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Reiniciar(); // se todos forem abilitados reinicia todos os botoes     
            }


        }


        private void Reiniciar()
        {
            foreach (Control item in this.Controls)//percorre a coleções de botões
            {
                if (item is Button)
                    item.Enabled = true; //se o item for um botão abilite 
                item.Text = String.Empty; // e o texto dele vira uma string vazia 
            }
        }


    }
}



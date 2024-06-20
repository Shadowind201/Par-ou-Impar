using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Par_ou_Impar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            int numeroJogador = 0, numeroComputador = 0, total;
            // três variavies inteiras: 'numeroJogador', 'numeroComputador' e 'total'
            // inicializando 'numeroJogador' e 'numeroComputador' com 0

            string nome = txtNome.Text;
            // uma variavel string 'nome' e atribui a ela o texto inserido na caixa de 'txtNome'

            Random dado = new Random();
            // cria uma instâcia da classe Randon para gerar números aleatorios

            numeroComputador = dado.Next(0, 11);
            // atribui á variavel 'numeroComputador' um número aleatorio entre 0 e 10

            numeroJogador = Convert.ToInt32(txtValor.Text);
            // converte o texto inserido na caixa de texto 'txtValor' para um inteiro e atribui esse valor a variavel 'numeroJogador'

            total = (numeroComputador + numeroJogador);
            // Calcula a soma de 'numeroComputador' e 'numeroJogador'

            MessageBox.Show("Seu número: " + txtValor.Text + "\nNumero do Computador: " + numeroComputador.ToString() + "\nTotal: " + total.ToString());
            // Exibe uma mensagem com os valores escolhidos pelo jogador, pelo computador e o total

            if (rdImpar.Checked == true)
            {
                if(total % 2 != 0)
                {
                    MessageBox.Show("Você escolheu ímpar. Parabens" + nome + ", você ganhou!");
                }
                else
                {
                    MessageBox.Show("Você escolheu ímpar. " + nome + ", você perdeu");
                }
            }
            else
            {
                if (total % 2 != 0)
                {
                    MessageBox.Show("Você secolheu par. Parabens " + nome + ", você ganhou!");
                }
                else
                {
                    MessageBox.Show("Você escolheu par. " + nome + ", você pedeu!");
                }
            }
        }
    }
}

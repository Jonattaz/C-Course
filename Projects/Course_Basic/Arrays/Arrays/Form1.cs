using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[4];
            vetor[0] = 7;
            vetor[1] = 3;
            vetor[2] = 5;
            vetor[3] = 1;

            int valor = vetor[1];
            System.Array.Sort(vetor);
            for (int index = 0; index < 4; index++)
            {
                MessageBox.Show(vetor[index].ToString(), "Array");

            }
            /* Declarar e instanciar vetor
             * Atribuição de valores de acordo com cada índice
             * Declara variável "valor" para acessar o vetor
             * System.Array.Sort - Esta classe ordena o vetor
             * Comando for- percorre o vetor em cada índice.
             * Condição - Para index menor que 4 (de 0 a 3), ele
             * exibe uma mensagem com o vetor na MessageBox
             */




        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string[] semana = new string[7];
            semana[0] = "Domingo";
            semana[1] = "Segunda-Feira";
            semana[2] = "Terça-Feira";
            semana[3] = "Quarta-Feira";
            semana[4] = "Quinta-Feira";
            semana[5] = "Sexta-Feira";
            semana[6] = "Sábado";


            string valor = semana[1];
            for (int index = 0; index < 7; index++)
            {
                MessageBox.Show(semana[index].ToString(), "Array");
            }
            /*Declarar e instanciar vetor
             * Atribuição de valores de acordo com cada índice,
             * aqui no caso são dias de semana(String)
             * Declara variável "valor" para acessar o vetor
             * por se tratar de string não será necessário ordenar
             * Comando for - percorre o vetor em cada índice.
             * Condição para index menor que 7 (de o a 6), ele
             * exibe uma mensagem com o vetor MessageBox, ou seja
             * cada dia da semana
             */







        }
    }
}




















using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            novo.Show();
            this.Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int contador;
            contador = 2021;
            while(contador >= 1950)
            {
                comboBox1.Items.Add(contador);
                contador--;
            }
            /*
             * Declaração da variável contador do tipo inteiro,
             * onde foi atribuído o valor de 2021(ano),
             * enquanto o contador for maior ou igual a 1950, o
             * contador faz o decremento.
             * Ou seja começa com 2021 e vai até 1950.
             * Itens são adicionados no contador.
             */

        }
    }
}

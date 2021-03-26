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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 novo1 = new Form1();
            novo1.Show();

            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 novo = new Form3();
            novo.Show();

            this.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int contador;

            for (contador = 2021; contador >= 1950; contador--)
            {
                comboBox1.Items.Add(contador);
            }

            /* 
             * Declaração da variável contador do tipo inteiro
             * Laço For - Atribuído o valor de 2021(ano), até
             * que o ano seja igual ou maior a 1950, o contador
             *  vai fazendo o decremento.
             * Ou seja começa com 2021 e vai até 1950.
             * Em seguida os itens são adicionados no Contador.
             */
        }
    }
}

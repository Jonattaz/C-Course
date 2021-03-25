using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tabuada.Items.Clear();
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            // Apresenta o formulário e chama em segguida
            novo.Show();
            // Fecha o formulário atual
            this.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num, resultado, i;
            i = 1;
            num = int.Parse(textBox1.Text);
            while (i <= 10)
            {
                resultado = i * num;
                Tabuada.Items.Add(String.Concat(num, " * ",
                    i, " = ", resultado));
                i++;
            }
             /*  Declaração das variáveis do tipo inteiro
              *  conversão para int
              *  condição enquanto o i for menor ou igual 10
              *  variável resultado realiza o cálculo de i
              *  multiplicado pelo número digitado.
              *  listBox adicionao item e concatena (número * i =
              *  resultado)
              *  Incremento
              */


        }
    }
}

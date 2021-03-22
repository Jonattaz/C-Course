using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Average_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Variaveis
            double n1, n2, n3, media;
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            n3 = Convert.ToDouble(textBox3.Text);
            media = (n1 + n2 + n3) / 3;

            textBox4.Text = media.ToString();

            if (media >= 7) 
            {
                MessageBox.Show("Aprovado", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (media < 7 && media >= 4)
            {
                MessageBox.Show("Recuperação", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Reprovado", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

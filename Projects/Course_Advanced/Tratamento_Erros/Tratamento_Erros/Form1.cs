using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tratamento_Erros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int num1, num2, resultado;

                num1 = int.Parse(textBox1.Text);
                num2 = int.Parse(textBox2.Text);
                resultado = num1 + num2;
                textBox3.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite apenas valores numericos", "Catch");
            }
            finally
            {
                MessageBox.Show("Aperte ok, para sair", "Finally");
                Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("");
            textBox2.Text = ("");
            textBox3.Text = ("");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_Calc
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Declaração de variáveis
             * variável  recebe conteúdo do textbox*/
            double peso, altura, imc;
            peso = Convert.ToDouble(textBox1.Text);
            altura = Convert.ToDouble(textBox2.Text);
            imc = peso / (altura * altura);
            /* textbox recebe conteúdo da variável imc = resultado 
             * do cálculo
             * definição de utilização de 2 casas decimais*/
            textBox3.Text = imc.ToString("0.00");
            /* Condições de acordo com os resultados dos cálculos
             * serão exibidas mensagens,
             * configuração das messagebox, (mensagens, botões,
             * ícones)
             * Como são varias condições temos um encadeamento de ifs */
            if (imc < 18.49)
            
                MessageBox.Show("SITUAÇÃO: Você está abaixo do peso", "Resultado", 
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (imc < 24.99)
                MessageBox.Show("SITUAÇÃO: Você está com o peso dentro da normalidade", "Resultado",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 29.99)
                MessageBox.Show("SITUAÇÃO: Você está acima do peso", "Resultado",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if(imc < 34.99)
                MessageBox.Show("ATENÇÃO! Você está com obesidade grau I", "Resultado",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (imc < 39.99)
                MessageBox.Show("AATENÇÃO! Você está com obesidade grau II", "Resultado",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
                MessageBox.Show("ATENÇÃO! Você está com obesidade grau III (mórbida)", "Resultado",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

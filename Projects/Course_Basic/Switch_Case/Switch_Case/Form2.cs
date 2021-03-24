using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(comboBox1.Text)
            /* De acordo com o final da placa escolhida no combobox 
             * será exibida uma mensagem informativa.
             * Caso o final da placa seja 1 ou 2 o rodízio será segunda,
             * caso 3 ou 4 na terça e assim por diante*/
            {
                case "1 ou 2":
                    label3.Text = "O dia do seu rodízio é Segunda-Feira!";
                    break;
                case "3 ou 4":
                    label3.Text = "O dia do seu rodízio é Terça-Feira!";
                    break;
                case "5 ou 6":
                    label3.Text = "O dia do seu rodízio é Quarta-Feira!";
                    break;
                case "7 ou 8":
                    label3.Text = "O dia do seu rodízio é Quinta-Feira!";
                    break;
                case "9 ou 0":
                    label3.Text = "O dia do seu rodízio é Sexta-Feira!";
                    break;




            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
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
            Close();
        }
    }
}

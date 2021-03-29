using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, senha;
            usuario = textBox1.Text;
            senha = textBox2.Text;

            if (usuario == "Admin" && senha == "Admin")
            {
                Form2 novo = new Form2();
                novo.Show();
                this.Visible = false;

            }
            else
            {
                MessageBox.Show("Senha errada, tente novamente:", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /* Declaração de variáveis e atribuição
             * condição - Se o usuário e (&&) senha forem
             * iguais a Admin, será chamadoo form2.
             *  Ou seja ele terá acesso ao sistema, somente se
             *  o usuário e senha estiverem corretos
             */
            
        }
    }
}

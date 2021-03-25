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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 novo = new Form3();
            // Apresenta o formulário e chama em segguida
            novo.Show();
            // Fecha o formulário atual
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            While novo = new While();
            // Apresenta o formulário e chama em segguida
            novo.Show();
            // Fecha o formulário atual
            this.Visible = false;
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = 1;
            while (num <= 10)
            {
                Contagem.Items.Add(num);
                num += 1;
                
                /* Declaração da variável numero do tipo inteiro,a variável foi inicializada
                 * com o número 1.
                 * "Enquanto" o número for menor ou iguala 5 o
                 * listBox será preenchido
                 * expressão = numero + 1 é o incremento
                 */
            }

        }
    }
}

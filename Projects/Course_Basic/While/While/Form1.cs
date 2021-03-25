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
    public partial class While : Form
    {
        public While()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            while(c < 1000)
            {
                c += 1;
                label1.Text = Convert.ToString(c);
                label1.Refresh();

                /* Declaração de variável c, incializada com zero.
                 * Condição: enquanto c for menor que 10000
                 * será executado o laço
                 * Incremento
                 * Refresh é utilizado para que haja a variação do número
                 */

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            /* Declara o objeto novo do tipo form e chama
             * em seguida atráves do método Show.
            */
            novo.Show();

            // Fecha formulário atual
            this.Visible = false;
        }
    }
}

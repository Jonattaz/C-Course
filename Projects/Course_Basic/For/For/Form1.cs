using System;
using System.Windows.Forms;

namespace For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int contador = 0; contador <= 50; contador++)
            {
                MessageBox.Show("O valor do contador é: " + 
                    contador); 
                contador++;
                /* Console.WriteLine("O valor de contador é: " + contador);
                WriteLine - é o comando que pula linha.
                */

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            novo.Show();


            this.Visible = false;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;

            do
            {
                num++;
                label2.Text = Convert.ToString(num);
                label2.Refresh();
            }
            while (num < 5000);

            /*Sempre executa poisa condição só apareceno final,
             * só é utilizada quando é necessário testar 
             * condição depois.
             */



        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }
    }
}

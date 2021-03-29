using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_Multi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[2, 4];
            notas[0, 0] = 8.0;
            notas[0, 1] = 7.4;
            notas[0, 2] = 10;
            notas[0, 3] = 6.5;
            notas[1, 0] = 10;
            notas[1, 1] = 10;
            notas[1, 2] = 9;
            notas[1, 3] = 9;

            MessageBox.Show(notas[0, 0].ToString(), "Array") ;
            MessageBox.Show(notas[0, 1].ToString(), "Array") ;
            MessageBox.Show(notas[0, 2].ToString(), "Array") ;
            MessageBox.Show(notas[0, 3].ToString(), "Array") ;
            MessageBox.Show(notas[1, 0].ToString(), "Array") ;
            MessageBox.Show(notas[1, 1].ToString(), "Array") ;
            MessageBox.Show(notas[1, 2].ToString(), "Array") ;
            MessageBox.Show(notas[1, 3].ToString(), "Array") ;

            /* Declarar e instanciar array, indicando a quantidade
             * de linhas e colunas.
             * Atribuição de valores com cada índice,
             * exibe na MessageBox a devida nota de acordo com os
             * índices escolhidos.
             */




        }
    }
}

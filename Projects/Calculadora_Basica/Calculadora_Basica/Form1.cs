using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Basica
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
            //Variables
            double num1, num2, resultado;

            //Convert the numbers to double
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);

            //Sum 
            resultado = num1 + num2;

            //Convert resultado to String
            textResult.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Variables
            double num1, num2, resultado;

            //Convert the numbers to double
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);

            //multiplication
            resultado = num1 * num2;

            //Convert resultado to String
            textResult.Text = resultado.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textNum1.Text = "";
            textNum2.Text = "";
            textResult.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Variables
            double num1, num2, resultado;

            //Convert the numbers to double
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);

            //Subtraction
            resultado = num1 - num2;

            //Convert resultado to String
            textResult.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //Variables
            double num1, num2, resultado;

            //Convert the numbers to double
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);

            //Division
            resultado = num1 / num2;

            //Convert resultado to String
            textResult.Text = resultado.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

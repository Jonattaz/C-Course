using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Cantina
{
    public partial class Form1 : Form
    {
        string[] produtos = new string[10];
        string[] codigo = new string[10];
        double[] valor = new double[10];
        double soma;
        /* Declaração de 3 arrays para armazenar 10 produtos, 
         * e seus respectivos códigos e valores.
         */


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            if (textBox1.Text.Length == 3)
            /* Inicia com uma condição, se o usuário digitar
        * um código com 3 caracteres (length), esse código
        * é adicionado ao listbox.
        * A propriedade Length retorna a quantidade de
        * caracteres.
        * */
            {
                int indice = 0;
                for (int prod = 0; prod < codigo.Length; prod++)
                    /*Faça enquanto o prod for menor ou igual 
                     * a quantidade de itens do array
                     */
                {
                    if (textBox1.Text  == codigo[prod])
                    {
                        indice = prod;
                    }
                }
                if (indice == 0)
                {
                    MessageBox.Show("Produto não encontrado");
                    /* Condição, se foi encontrado o produto 
                     * ele retorna as informações de acordo com o
                     * índice
                     * Caso não encontre aparecerá a  mensagem, produto não encontrado
                     */
                }
                else
                {
                    listBox1.Items.Add(textBox1.Text + "--" + produtos[indice] + "-- R$" +
                        valor[indice]);
                    /* Conteúdo adicionado no ListBox, concatena (+) as informações 
                     * (código/nome/valor)
                     */

                    soma = soma + valor[indice];
                    label3.Text = ("Valor total R$ " + soma);
                    pictureBox1.ImageLocation = "c:/Imagens/" + codigo[indice] + ".jpg";
                    textBox1.Text = "";
                    textBox1.Focus();
                    /* Localização da imagem que deve ser colocada em uma pasta em c:
                     *  numa pasta imagens
                     *  
                     *  O TextBox será limpo e o focus posiciona o cursor para
                     *  o TextBox numa nova digitação
                     */

                }


            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarArray();
            soma = 0;
        }

        // Ao entrar no Form Load será chamado o método

        private void CarregarArray()
        /* Criação do método para ser chamado quando necessário,
         * isso evita repetir várias vezes o mesmo código
         */

        {
            codigo[1] = "001";
            codigo[2] = "002";
            codigo[3] = "003";
            codigo[4] = "004";
            codigo[5] = "005";

            produtos[1] = "Pastel";
            produtos[2] = "Coxinha";
            produtos[3] = "Hot Dog";
            produtos[4] = "Chocolate";
            produtos[5] = "Suco";

            valor[1] = 6.00;
            valor[2] = 5.00;
            valor[3] = 12.00;
            valor[4] = 3.50;
            valor[5] = 8.00;

            /* Códigos, produtos e valores referência os arrays 
             * que foram declarados
             */

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}



















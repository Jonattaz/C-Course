
namespace Calculadora_Basica
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(209, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora básica";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(112, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o 2º número:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(141, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(112, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Digite o 1º número:";
            // 
            // textNum1
            // 
            this.textNum1.BackColor = System.Drawing.Color.Black;
            this.textNum1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNum1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textNum1.Location = new System.Drawing.Point(287, 109);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(301, 27);
            this.textNum1.TabIndex = 4;
            this.textNum1.TextChanged += new System.EventHandler(this.textNum1_TextChanged);
            // 
            // textNum2
            // 
            this.textNum2.BackColor = System.Drawing.Color.Black;
            this.textNum2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNum2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textNum2.Location = new System.Drawing.Point(286, 152);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(301, 27);
            this.textNum2.TabIndex = 5;
            this.textNum2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textResult
            // 
            this.textResult.BackColor = System.Drawing.Color.Black;
            this.textResult.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResult.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textResult.Location = new System.Drawing.Point(286, 192);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(301, 27);
            this.textResult.TabIndex = 6;
            this.textResult.TextChanged += new System.EventHandler(this.textResult_TextChanged);
            // 
            // btnAdicao
            // 
            this.btnAdicao.BackColor = System.Drawing.Color.Black;
            this.btnAdicao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAdicao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdicao.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicao.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdicao.Location = new System.Drawing.Point(163, 242);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(75, 66);
            this.btnAdicao.TabIndex = 7;
            this.btnAdicao.Text = "+";
            this.btnAdicao.UseVisualStyleBackColor = false;
            this.btnAdicao.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.Color.Black;
            this.btnMulti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMulti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMulti.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMulti.Location = new System.Drawing.Point(163, 328);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(75, 66);
            this.btnMulti.TabIndex = 8;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.Color.Black;
            this.btnMenos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMenos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMenos.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMenos.Location = new System.Drawing.Point(273, 242);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(75, 66);
            this.btnMenos.TabIndex = 9;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.Color.Black;
            this.btnDivisao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDivisao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDivisao.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDivisao.Location = new System.Drawing.Point(273, 328);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(75, 66);
            this.btnDivisao.TabIndex = 10;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.BackColor = System.Drawing.Color.Black;
            this.btnLimp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLimp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLimp.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimp.Location = new System.Drawing.Point(452, 250);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(135, 50);
            this.btnLimp.TabIndex = 11;
            this.btnLimp.Text = "Limpar";
            this.btnLimp.UseVisualStyleBackColor = false;
            this.btnLimp.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Black;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSair.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSair.Location = new System.Drawing.Point(452, 336);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(135, 50);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculadora_Basica.Properties.Resources._45418;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora Espacial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnLimp;
    }
}


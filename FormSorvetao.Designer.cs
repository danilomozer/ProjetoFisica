namespace ProjetoFisica
{
    partial class FormSorvetao
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
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPosicaoInicial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPosicaoFinal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVelocidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAceleracao = new System.Windows.Forms.TextBox();
            this.btn_Ajuda = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equação : y = yo + voyt + 1/2at²";
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(16, 255);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 13;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(190, 255);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 12;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Posição Inicial";
            // 
            // txtPosicaoInicial
            // 
            this.txtPosicaoInicial.Location = new System.Drawing.Point(102, 73);
            this.txtPosicaoInicial.Name = "txtPosicaoInicial";
            this.txtPosicaoInicial.Size = new System.Drawing.Size(100, 20);
            this.txtPosicaoInicial.TabIndex = 3;
            this.txtPosicaoInicial.Leave += new System.EventHandler(this.txtPosicaoInicial_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Posição Final ";
            // 
            // txtPosicaoFinal
            // 
            this.txtPosicaoFinal.Location = new System.Drawing.Point(102, 108);
            this.txtPosicaoFinal.Name = "txtPosicaoFinal";
            this.txtPosicaoFinal.Size = new System.Drawing.Size(100, 20);
            this.txtPosicaoFinal.TabIndex = 5;
            this.txtPosicaoFinal.Leave += new System.EventHandler(this.txtPosicaoFinal_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Velocidade ";
            // 
            // txtVelocidade
            // 
            this.txtVelocidade.Location = new System.Drawing.Point(102, 143);
            this.txtVelocidade.Name = "txtVelocidade";
            this.txtVelocidade.Size = new System.Drawing.Size(100, 20);
            this.txtVelocidade.TabIndex = 7;
            this.txtVelocidade.Leave += new System.EventHandler(this.txtVelocidadeInicial_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tempo";
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(102, 179);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(100, 20);
            this.txtTempo.TabIndex = 9;
            this.txtTempo.Leave += new System.EventHandler(this.txtTempo_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Aceleração (g)";
            // 
            // txtAceleracao
            // 
            this.txtAceleracao.Enabled = false;
            this.txtAceleracao.Location = new System.Drawing.Point(102, 216);
            this.txtAceleracao.Name = "txtAceleracao";
            this.txtAceleracao.ReadOnly = true;
            this.txtAceleracao.Size = new System.Drawing.Size(100, 20);
            this.txtAceleracao.TabIndex = 11;
            this.txtAceleracao.Text = "-10 m/s²";
            // 
            // btn_Ajuda
            // 
            this.btn_Ajuda.Location = new System.Drawing.Point(102, 255);
            this.btn_Ajuda.Name = "btn_Ajuda";
            this.btn_Ajuda.Size = new System.Drawing.Size(75, 23);
            this.btn_Ajuda.TabIndex = 14;
            this.btn_Ajuda.Text = "Ajuda";
            this.btn_Ajuda.UseVisualStyleBackColor = true;
            this.btn_Ajuda.Click += new System.EventHandler(this.btn_Ajuda_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nota: Lembre-se que para está equação os valores \r\nde referência são em y";
            // 
            // FormSorvetao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 291);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Ajuda);
            this.Controls.Add(this.txtAceleracao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVelocidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPosicaoFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPosicaoInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.label1);
            this.Name = "FormSorvetao";
            this.Text = "Equação de Torricelli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPosicaoInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPosicaoFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVelocidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAceleracao;
        private System.Windows.Forms.Button btn_Ajuda;
        private System.Windows.Forms.Label label7;
    }
}
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
            this.txtVelocidadeInicial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAceleracao = new System.Windows.Forms.TextBox();
            this.btn_Ajuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equação : y = yo + vot + 1/2at²";
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(20, 278);
            this.btn_Voltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(100, 28);
            this.btn_Voltar.TabIndex = 1;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(276, 278);
            this.btn_Calcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(100, 28);
            this.btn_Calcular.TabIndex = 2;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Posição Inicial";
            // 
            // txtPosicaoInicial
            // 
            this.txtPosicaoInicial.Location = new System.Drawing.Point(156, 62);
            this.txtPosicaoInicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPosicaoInicial.Name = "txtPosicaoInicial";
            this.txtPosicaoInicial.Size = new System.Drawing.Size(132, 22);
            this.txtPosicaoInicial.TabIndex = 4;
            this.txtPosicaoInicial.Leave += new System.EventHandler(this.txtPosicaoInicial_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Posição Final";
            // 
            // txtPosicaoFinal
            // 
            this.txtPosicaoFinal.Location = new System.Drawing.Point(156, 106);
            this.txtPosicaoFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPosicaoFinal.Name = "txtPosicaoFinal";
            this.txtPosicaoFinal.Size = new System.Drawing.Size(132, 22);
            this.txtPosicaoFinal.TabIndex = 6;
            this.txtPosicaoFinal.Leave += new System.EventHandler(this.txtPosicaoFinal_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Velocidade Inicial";
            // 
            // txtVelocidadeInicial
            // 
            this.txtVelocidadeInicial.Location = new System.Drawing.Point(156, 148);
            this.txtVelocidadeInicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVelocidadeInicial.Name = "txtVelocidadeInicial";
            this.txtVelocidadeInicial.Size = new System.Drawing.Size(132, 22);
            this.txtVelocidadeInicial.TabIndex = 8;
            this.txtVelocidadeInicial.Leave += new System.EventHandler(this.txtVelocidadeInicial_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tempo";
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(156, 192);
            this.txtTempo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(132, 22);
            this.txtTempo.TabIndex = 10;
            this.txtTempo.Leave += new System.EventHandler(this.txtTempo_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Aceleração";
            // 
            // txtAceleracao
            // 
            this.txtAceleracao.Location = new System.Drawing.Point(156, 229);
            this.txtAceleracao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAceleracao.Name = "txtAceleracao";
            this.txtAceleracao.Size = new System.Drawing.Size(132, 22);
            this.txtAceleracao.TabIndex = 12;
            this.txtAceleracao.Leave += new System.EventHandler(this.txtAceleracao_Leave);
            // 
            // btn_Ajuda
            // 
            this.btn_Ajuda.Location = new System.Drawing.Point(168, 278);
            this.btn_Ajuda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Ajuda.Name = "btn_Ajuda";
            this.btn_Ajuda.Size = new System.Drawing.Size(100, 28);
            this.btn_Ajuda.TabIndex = 13;
            this.btn_Ajuda.Text = "Ajuda";
            this.btn_Ajuda.UseVisualStyleBackColor = true;
            // 
            // FormSorvetao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 319);
            this.Controls.Add(this.btn_Ajuda);
            this.Controls.Add(this.txtAceleracao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVelocidadeInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPosicaoFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPosicaoInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtVelocidadeInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAceleracao;
        private System.Windows.Forms.Button btn_Ajuda;
    }
}
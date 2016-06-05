namespace ProjetoFisica
{
    partial class FormSorvete
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPosicaoInicial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPosicaoFinal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVelocidadeInicial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equação : x = xo + vot";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(17, 236);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 28);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.Location = new System.Drawing.Point(143, 236);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(100, 28);
            this.btnAjuda.TabIndex = 2;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(267, 236);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Posição Inicial";
            // 
            // txtPosicaoInicial
            // 
            this.txtPosicaoInicial.Location = new System.Drawing.Point(143, 49);
            this.txtPosicaoInicial.Margin = new System.Windows.Forms.Padding(4);
            this.txtPosicaoInicial.Name = "txtPosicaoInicial";
            this.txtPosicaoInicial.Size = new System.Drawing.Size(132, 22);
            this.txtPosicaoInicial.TabIndex = 5;
            this.txtPosicaoInicial.Leave += new System.EventHandler(this.txtPosicaoInicial_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Posição Final";
            // 
            // txtPosicaoFinal
            // 
            this.txtPosicaoFinal.Location = new System.Drawing.Point(143, 97);
            this.txtPosicaoFinal.Margin = new System.Windows.Forms.Padding(4);
            this.txtPosicaoFinal.Name = "txtPosicaoFinal";
            this.txtPosicaoFinal.Size = new System.Drawing.Size(132, 22);
            this.txtPosicaoFinal.TabIndex = 7;
            this.txtPosicaoFinal.Leave += new System.EventHandler(this.txtPosicaoFinal_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Velocidade Inicial";
            // 
            // txtVelocidadeInicial
            // 
            this.txtVelocidadeInicial.Location = new System.Drawing.Point(143, 143);
            this.txtVelocidadeInicial.Margin = new System.Windows.Forms.Padding(4);
            this.txtVelocidadeInicial.Name = "txtVelocidadeInicial";
            this.txtVelocidadeInicial.Size = new System.Drawing.Size(132, 22);
            this.txtVelocidadeInicial.TabIndex = 9;
            this.txtVelocidadeInicial.Leave += new System.EventHandler(this.txtVelocidadeInicial_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tempo";
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(143, 190);
            this.txtTempo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(132, 22);
            this.txtTempo.TabIndex = 11;
            this.txtTempo.Leave += new System.EventHandler(this.txtTempo_Leave);
            // 
            // FormSorvete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 282);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVelocidadeInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPosicaoFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPosicaoInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSorvete";
            this.Text = "Equação da Posição";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPosicaoInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPosicaoFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVelocidadeInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTempo;
    }
}
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
            this.txtVelocidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equação : x = xo + voxt";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 227);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.Location = new System.Drawing.Point(96, 227);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(75, 23);
            this.btnAjuda.TabIndex = 12;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(190, 227);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Posição Inicial";
            // 
            // txtPosicaoInicial
            // 
            this.txtPosicaoInicial.Location = new System.Drawing.Point(96, 77);
            this.txtPosicaoInicial.Name = "txtPosicaoInicial";
            this.txtPosicaoInicial.Size = new System.Drawing.Size(100, 20);
            this.txtPosicaoInicial.TabIndex = 3;
            this.txtPosicaoInicial.Leave += new System.EventHandler(this.txtPosicaoInicial_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Posição Final";
            // 
            // txtPosicaoFinal
            // 
            this.txtPosicaoFinal.Location = new System.Drawing.Point(96, 116);
            this.txtPosicaoFinal.Name = "txtPosicaoFinal";
            this.txtPosicaoFinal.Size = new System.Drawing.Size(100, 20);
            this.txtPosicaoFinal.TabIndex = 5;
            this.txtPosicaoFinal.Leave += new System.EventHandler(this.txtPosicaoFinal_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Velocidade";
            // 
            // txtVelocidade
            // 
            this.txtVelocidade.Location = new System.Drawing.Point(96, 153);
            this.txtVelocidade.Name = "txtVelocidade";
            this.txtVelocidade.Size = new System.Drawing.Size(100, 20);
            this.txtVelocidade.TabIndex = 7;
            this.txtVelocidade.Leave += new System.EventHandler(this.txtVelocidade_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tempo";
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(96, 191);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(100, 20);
            this.txtTempo.TabIndex = 9;
            this.txtTempo.Leave += new System.EventHandler(this.txtTempo_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nota: Lembre-se que para está equação os valores \r\nde referência são em x";
            // 
            // FormSorvete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 262);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVelocidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPosicaoFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPosicaoInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox txtVelocidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label label6;
    }
}
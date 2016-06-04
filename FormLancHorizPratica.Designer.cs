namespace ProjetoFisica
{
    partial class FormLancHorizPratica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLancHorizPratica));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Utilizar = new System.Windows.Forms.Button();
            this.btn_Ajuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 104);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(15, 274);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 1;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Selecione a fórmula \r\ndesejada.";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "x = xo + vt",
            "y = yo + vot + 1/2at²"});
            this.comboBox1.Location = new System.Drawing.Point(121, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // btn_Utilizar
            // 
            this.btn_Utilizar.Location = new System.Drawing.Point(264, 150);
            this.btn_Utilizar.Name = "btn_Utilizar";
            this.btn_Utilizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Utilizar.TabIndex = 6;
            this.btn_Utilizar.Text = "Utilizar";
            this.btn_Utilizar.UseVisualStyleBackColor = true;
            this.btn_Utilizar.Click += new System.EventHandler(this.btn_Utilizar_Click);
            // 
            // btn_Ajuda
            // 
            this.btn_Ajuda.Location = new System.Drawing.Point(264, 274);
            this.btn_Ajuda.Name = "btn_Ajuda";
            this.btn_Ajuda.Size = new System.Drawing.Size(75, 23);
            this.btn_Ajuda.TabIndex = 7;
            this.btn_Ajuda.Text = "Ajuda";
            this.btn_Ajuda.UseVisualStyleBackColor = true;
            // 
            // FormLancHorizPratica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 309);
            this.Controls.Add(this.btn_Ajuda);
            this.Controls.Add(this.btn_Utilizar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.label1);
            this.Name = "FormLancHorizPratica";
            this.Text = "Lançamento Horizontal - Prática";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Utilizar;
        private System.Windows.Forms.Button btn_Ajuda;
    }
}
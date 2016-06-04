namespace ProjetoFisica
{
    partial class FormLancHorizTeoria
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
            this.btn_Testar_Conhecimentos = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Testar_Conhecimentos
            // 
            this.btn_Testar_Conhecimentos.Location = new System.Drawing.Point(691, 376);
            this.btn_Testar_Conhecimentos.Name = "btn_Testar_Conhecimentos";
            this.btn_Testar_Conhecimentos.Size = new System.Drawing.Size(123, 23);
            this.btn_Testar_Conhecimentos.TabIndex = 0;
            this.btn_Testar_Conhecimentos.Text = "Testar Conhecimentos";
            this.btn_Testar_Conhecimentos.UseVisualStyleBackColor = true;
            this.btn_Testar_Conhecimentos.Click += new System.EventHandler(this.btn_Testar_Conhecimentos_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(17, 376);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 1;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // FormLancHorizTeoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 414);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Testar_Conhecimentos);
            this.Name = "FormLancHorizTeoria";
            this.Text = "Lançamento Horizontal - Teoria";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Testar_Conhecimentos;
        private System.Windows.Forms.Button btn_Voltar;
    }
}
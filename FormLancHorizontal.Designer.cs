namespace ProjetoFisica
{
    partial class FormLancHorizontal
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
            this.btn_Teoria = new System.Windows.Forms.Button();
            this.btn_Exercicios = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Teoria
            // 
            this.btn_Teoria.Location = new System.Drawing.Point(42, 49);
            this.btn_Teoria.Name = "btn_Teoria";
            this.btn_Teoria.Size = new System.Drawing.Size(75, 23);
            this.btn_Teoria.TabIndex = 0;
            this.btn_Teoria.Text = "Teoria";
            this.btn_Teoria.UseVisualStyleBackColor = true;
            this.btn_Teoria.Click += new System.EventHandler(this.btn_Teoria_Click);
            // 
            // btn_Exercicios
            // 
            this.btn_Exercicios.Location = new System.Drawing.Point(169, 49);
            this.btn_Exercicios.Name = "btn_Exercicios";
            this.btn_Exercicios.Size = new System.Drawing.Size(75, 23);
            this.btn_Exercicios.TabIndex = 1;
            this.btn_Exercicios.Text = "Exercícios";
            this.btn_Exercicios.UseVisualStyleBackColor = true;
            this.btn_Exercicios.Click += new System.EventHandler(this.btn_Exercicios_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(12, 103);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 2;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // FormLancHorizontal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 138);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Exercicios);
            this.Controls.Add(this.btn_Teoria);
            this.Name = "FormLancHorizontal";
            this.Text = "Lançamento Horizontal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Teoria;
        private System.Windows.Forms.Button btn_Exercicios;
        private System.Windows.Forms.Button btn_Voltar;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLancHorizTeoria));
            this.btn_Testar_Conhecimentos = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Testar_Conhecimentos
            // 
            this.btn_Testar_Conhecimentos.Location = new System.Drawing.Point(691, 401);
            this.btn_Testar_Conhecimentos.Name = "btn_Testar_Conhecimentos";
            this.btn_Testar_Conhecimentos.Size = new System.Drawing.Size(123, 23);
            this.btn_Testar_Conhecimentos.TabIndex = 0;
            this.btn_Testar_Conhecimentos.Text = "Testar Conhecimentos";
            this.btn_Testar_Conhecimentos.UseVisualStyleBackColor = true;
            this.btn_Testar_Conhecimentos.Click += new System.EventHandler(this.btn_Testar_Conhecimentos_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(17, 401);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 1;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(366, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(448, 372);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormLancHorizTeoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 437);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Testar_Conhecimentos);
            this.Name = "FormLancHorizTeoria";
            this.Text = "Lançamento Horizontal - Teoria";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Testar_Conhecimentos;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
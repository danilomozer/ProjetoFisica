namespace ProjetoFisica
{
    partial class FormMenu
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
            this.btn_Queda_Livre = new System.Windows.Forms.Button();
            this.btn_Lanc_Horizontal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Queda_Livre
            // 
            this.btn_Queda_Livre.Location = new System.Drawing.Point(27, 65);
            this.btn_Queda_Livre.Name = "btn_Queda_Livre";
            this.btn_Queda_Livre.Size = new System.Drawing.Size(130, 23);
            this.btn_Queda_Livre.TabIndex = 0;
            this.btn_Queda_Livre.Text = "Queda Livre";
            this.btn_Queda_Livre.UseVisualStyleBackColor = true;
            // 
            // btn_Lanc_Horizontal
            // 
            this.btn_Lanc_Horizontal.Location = new System.Drawing.Point(183, 65);
            this.btn_Lanc_Horizontal.Name = "btn_Lanc_Horizontal";
            this.btn_Lanc_Horizontal.Size = new System.Drawing.Size(130, 23);
            this.btn_Lanc_Horizontal.TabIndex = 1;
            this.btn_Lanc_Horizontal.Text = "Lançamento Horizontal";
            this.btn_Lanc_Horizontal.UseVisualStyleBackColor = true;
            this.btn_Lanc_Horizontal.Click += new System.EventHandler(this.btn_Lanc_Horizontal_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 177);
            this.Controls.Add(this.btn_Lanc_Horizontal);
            this.Controls.Add(this.btn_Queda_Livre);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Queda_Livre;
        private System.Windows.Forms.Button btn_Lanc_Horizontal;
    }
}


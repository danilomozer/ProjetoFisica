﻿namespace ProjetoFisica
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
            this.btn_Teoria = new System.Windows.Forms.Button();
            this.btn_Exercicios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Teoria
            // 
            this.btn_Teoria.Location = new System.Drawing.Point(27, 65);
            this.btn_Teoria.Name = "btn_Teoria";
            this.btn_Teoria.Size = new System.Drawing.Size(130, 23);
            this.btn_Teoria.TabIndex = 1;
            this.btn_Teoria.Text = "Teoria";
            this.btn_Teoria.UseVisualStyleBackColor = true;
            this.btn_Teoria.Click += new System.EventHandler(this.btn_Teoria_Click);
            // 
            // btn_Exercicios
            // 
            this.btn_Exercicios.Location = new System.Drawing.Point(183, 65);
            this.btn_Exercicios.Name = "btn_Exercicios";
            this.btn_Exercicios.Size = new System.Drawing.Size(130, 23);
            this.btn_Exercicios.TabIndex = 2;
            this.btn_Exercicios.Text = "Exercicios";
            this.btn_Exercicios.UseVisualStyleBackColor = true;
            this.btn_Exercicios.Click += new System.EventHandler(this.btn_Exercicios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione a opção desejada.";
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(183, 103);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(130, 23);
            this.btn_Sair.TabIndex = 3;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 138);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exercicios);
            this.Controls.Add(this.btn_Teoria);
            this.Name = "FormMenu";
            this.Text = "Menu - Lançamento Horizontal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Teoria;
        private System.Windows.Forms.Button btn_Exercicios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sair;
    }
}


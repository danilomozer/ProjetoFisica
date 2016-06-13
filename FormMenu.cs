using System;
using System.Windows.Forms;

namespace ProjetoFisica
{
    public partial class FormMenu : Form
    {
        #region Construtor
        public FormMenu()
        {
            InitializeComponent();
        }
        #endregion

        #region Button
        private void btn_Teoria_Click(object sender, EventArgs e)
        {
            FormLancHorizTeoria teoria = new FormLancHorizTeoria();
            Hide();
            teoria.ShowDialog();
        }

        private void btn_Exercicios_Click(object sender, EventArgs e)
        {
            FormLancHorizPratica pratica = new FormLancHorizPratica();
            Hide();
            pratica.ShowDialog();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
        #endregion
    }
}
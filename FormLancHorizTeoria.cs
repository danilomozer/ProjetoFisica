using System;
using System.Windows.Forms;

namespace ProjetoFisica
{
    public partial class FormLancHorizTeoria : Form
    {
        public FormLancHorizTeoria()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            Hide();
            menu.ShowDialog();
        }

        private void btn_Testar_Conhecimentos_Click(object sender, EventArgs e)
        {
            FormLancHorizPratica lancHorizPratica = new FormLancHorizPratica();
            Hide();
            lancHorizPratica.ShowDialog();
        }
    }
}

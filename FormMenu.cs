using System;
using System.Windows.Forms;

namespace ProjetoFisica
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btn_Lanc_Horizontal_Click(object sender, EventArgs e)
        {
            FormLancHorizTeoria lancHorizTeoria = new FormLancHorizTeoria();
            Hide();
            lancHorizTeoria.ShowDialog();
        }
    }
}

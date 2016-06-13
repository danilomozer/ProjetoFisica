using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFisica
{
    public partial class FormLancHorizontal : Form
    {
        public FormLancHorizontal()
        {
            InitializeComponent();
        }

        private void btn_Teoria_Click(object sender, EventArgs e)
        {
            Hide();
            FormLancHorizTeoria lancHorizTeoria = new FormLancHorizTeoria();
            lancHorizTeoria.ShowDialog();
        }

        private void btn_Exercicios_Click(object sender, EventArgs e)
        {
            Hide();
            FormLancHorizPratica lancHorizPratica = new FormLancHorizPratica();
            lancHorizPratica.ShowDialog();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Hide();
            FormMenu menu = new FormMenu();
            menu.ShowDialog();
        }
    }
}

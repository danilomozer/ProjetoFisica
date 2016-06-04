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
    public partial class FormLancHorizPratica : Form
    {
        public FormLancHorizPratica()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            FormLancHorizTeoria lancHorizTeoria = new FormLancHorizTeoria();
            Hide();
            lancHorizTeoria.ShowDialog();
        }

        private void btn_Utilizar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                FormSorvete sorvete = new FormSorvete();
                sorvete.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                FormSorvetao sorvetao = new FormSorvetao();
                sorvetao.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma opção válida");
            }
        }
    }
}

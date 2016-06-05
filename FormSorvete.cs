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
    public partial class FormSorvete : Form
    {
        Formulas formula2 = new Formulas();

        public FormSorvete()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void txtPosicaoInicial_Leave(object sender, EventArgs e)
        {
            formula2.Posicao_Inicial_X = double.Parse(txtPosicaoInicial.Text);
        }

        private void txtPosicaoFinal_Leave(object sender, EventArgs e)
        {
            formula2.Posicao_Final_X = double.Parse(txtPosicaoInicial.Text);
        }

        private void txtVelocidadeInicial_Leave(object sender, EventArgs e)
        {
            formula2.Velocidade = double.Parse(txtVelocidadeInicial.Text);
        }

        private void txtTempo_Leave(object sender, EventArgs e)
        {
            formula2.Tempo = double.Parse(txtTempo.Text);
        }
    }
}

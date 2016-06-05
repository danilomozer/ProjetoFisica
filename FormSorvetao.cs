using System;
using System.Windows.Forms;

namespace ProjetoFisica
{
    public partial class FormSorvetao : Form
    {
 
        Formulas formula = new Formulas();

        public FormSorvetao()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void txtPosicaoInicial_Leave(object sender, EventArgs e)
        {
            formula.Posicao_Inicial_Y = double.Parse(txtPosicaoInicial.Text);
        }

        private void txtPosicaoFinal_Leave(object sender, EventArgs e)
        {
            formula.Posicao_Final_Y = double.Parse(txtPosicaoFinal.Text);
        }

        private void txtVelocidadeInicial_Leave(object sender, EventArgs e)
        {
            formula.Velocidade = double.Parse(txtVelocidadeInicial.Text);
        }

        private void txtTempo_Leave(object sender, EventArgs e)
        {
            formula.Tempo = double.Parse(txtTempo.Text);
        }

        private void txtAceleracao_Leave(object sender, EventArgs e)
        {
            formula.Aceleracao = double.Parse(txtAceleracao.Text);
        }
    }
}

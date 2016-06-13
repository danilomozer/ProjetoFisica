using System;
using System.Windows.Forms;

namespace ProjetoFisica
{
    public partial class FormSorvetao : Form
    {
        #region Construtor
        public FormSorvetao()
        {
            InitializeComponent();
        }
        #endregion

        Formulas formula = new Formulas();

        #region Fields da classe
        private double resultado;

        private string si;

        private double value;

        private bool teste;
        #endregion

        #region TextBox
        // Atribuição dos campos textos para as variaveis da classe.
        private void txtPosicaoInicial_Leave(object sender, EventArgs e)
        {
            // Essa verificação retorna um bool para a conversão do campo (True se conseguiu e False se não conseguiu).
            teste = double.TryParse(txtPosicaoInicial.Text, out value);

            // Se o teste for True significa que ele conseguiu converter, então atribui para a property.
            if (teste)
            {
                formula.Posicao_Inicial_Y = double.Parse(txtPosicaoInicial.Text);
                txtPosicaoInicial.Text = txtPosicaoInicial.Text + " m";
            }
            // Se retornar falso vai cair nessa condição, e será atribuido ao campo o valor "value", declarado como 0.
            else
            {
                formula.Posicao_Inicial_Y = value;
            }
        }

        private void txtPosicaoFinal_Leave(object sender, EventArgs e)
        {
            teste = double.TryParse(txtPosicaoFinal.Text, out value);

            if (teste)
            {
                formula.Posicao_Final_Y = double.Parse(txtPosicaoFinal.Text);
                txtPosicaoFinal.Text = txtPosicaoFinal.Text + " m";
            }
            else
            {
                formula.Posicao_Final_Y = value;
            }
        }

        private void txtVelocidadeInicial_Leave(object sender, EventArgs e)
        {
            teste = double.TryParse(txtVelocidade.Text, out value);

            if (teste)
            {
                formula.Velocidade = double.Parse(txtVelocidade.Text);
                txtVelocidade.Text = txtVelocidade.Text + " m/s";
            }
            else
            {
                formula.Velocidade = value;
            }
        }

        private void txtTempo_Leave(object sender, EventArgs e)
        {
            teste = double.TryParse(txtTempo.Text, out value);

            if (teste)
            {
                formula.Tempo = double.Parse(txtTempo.Text);
                txtTempo.Text = txtTempo.Text + " s";
            }
            else
            {
                formula.Tempo = value;
            }
        }
        #endregion

        #region Button
        // Botão Voltar
        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        // Botão Calcular.
        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (txtPosicaoInicial.Text == "")
            {
                resultado = formula.CalculaPosicao_Inicial_Y();
                si = "metros";
                MessageBox.Show("A posição inicial é de: " + resultado.ToString("0.00 ") + si);
                txtPosicaoInicial.Text = resultado.ToString("0.00 ") + " m";
            }

            if (txtPosicaoFinal.Text == "")
            {
                resultado = formula.CalculaPosicao_Final_Y();
                si = "metros";
                MessageBox.Show("A posição final é de: " + resultado.ToString("0.00 ") + si);
                txtPosicaoFinal.Text = resultado.ToString("0.00 ") + " m";
            }

            if (txtVelocidade.Text == "")
            {
                resultado = formula.CalculaVelocidade();
                si = "m/s";
                MessageBox.Show("A velocidade é de: " + resultado.ToString("0.00 ") + si);
                txtVelocidade.Text = resultado.ToString("0.00 ") + " m/s";
            }

            if (txtTempo.Text == "")
            {
                resultado = formula.CalculaTempo();
                si = "segundos";
                MessageBox.Show("O tempo é de: " + resultado.ToString("0.00 ") + si);
                txtTempo.Text = resultado.ToString("0.00 ") + " s";
            }

        }
        #endregion

        private void btn_Ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tLembre-se!\n\n" +
                            " - NÃO preencha o campo do valor que deseja descobrir.\n\n" +
                            " - Os campos devem ser preenchidos com as medidas padrões\n" +
                            "   do Sistema Internacional: \n\n" +
                            "    Distãncias e espaços : Metros (m)\n"+
                            "    Velocidade : Metros por segundo (m/s)\n"+
                            "    Tempo : Segundos (s)\n"+
                            "    Aceleração : Metros por Segundo(m/s²)"
                            );

        }
    }
}

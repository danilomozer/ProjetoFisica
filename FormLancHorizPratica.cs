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
            FormMenu menu = new FormMenu();
            Hide();
            menu.ShowDialog();
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

        private void btn_Ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para este exercício devemos começar calculando o tempo para que possamos conseguir" +
                             " calcular o alcance do dublê, sendo assim usaremos a seguinte fórmula: \n\n " +
                             "\t Y = Y0 + V0* Tempo + ½ * Aceleração * Tempo²\n\n" +
                             "Onde:\n" +
                             "\t• Y seria o pondo aonde o dublê toca ao solo;\n\n"+
                             "\t• Y0 a diferença entre as alturas dos prédios, sendo assim = 3;\n\n"+
                             "\t• V0*Tempo será inutilizado pelo fato da velocidade horizontal não\n"+
                             "\t influenciar nesse tipo de exercício;\n\n" +
                             "\t• Aceleração usaremos a da gravidade (10), e pelo fato dela estar\n"+
                             "\t “puxando” o dublê para o centro da terra ela será negativa;\n\n"+
                             "\t• Tempo deixaremos em branco, pois é a incógnita que precisamos\n" +
                             "\t descobrir;\n\n" + 
                             "Então: \n\n" +
                             "\t 0 = 3 – 10 / 2 * t² \n"+
                             "\t 5t² = 3 \n" +
                             "\t Tempo =  Raiz Quadrada de 0,6\n"+
                             "\t Ou seja 0,77 segundos.\n\n" +
                             "Com o tempo descoberto podemos descobrir a deslocação (horizontal) do dublê usando a seguinte fórmula: \n\n" +
                             "\t X = X0 + V * Tempo\n\n" +
                             "Então: \n\n"+
                             "\t X = 0 + 5 * 0,77 \n"+
                             "\t X = 3,87 metros\n\n"+
                             "O dublê não alcançou a borda");
        }
    }

    }


﻿using System;
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
    public partial class FormSorvetao : Form
    {
        public FormSorvetao()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            FormLancHorizPratica lancHorizPratica = new FormLancHorizPratica();
            Hide();
            lancHorizPratica.Show();
        }
    }
}

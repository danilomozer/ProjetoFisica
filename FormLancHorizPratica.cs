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
            lancHorizTeoria.Show();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandas
{
    public partial class FrmCardapio : Form
    {
        public FrmCardapio()
        {

            InitializeComponent();
        }

        private void FrmCardapio_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new FrmCardapioCad().ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}

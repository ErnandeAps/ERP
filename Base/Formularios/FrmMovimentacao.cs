﻿using Base.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erp
{
    public partial class FrmMovimentacao : Form
    {
        public FrmMovimentacao()
        {
            InitializeComponent();
        }

        private void FrmVendas_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrcamento_Click(object sender, EventArgs e)
        {

        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            FrmLocDav frm = new FrmLocDav();
            frm.ShowDialog();
        }
    }
}

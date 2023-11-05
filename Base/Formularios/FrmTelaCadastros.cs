using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Erp;
using Base.Formularios;

namespace Erp
{
    public partial class FrmTelaCadastros : Form
    {
        public FrmTelaCadastros()
        {

            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

            frmLocClientes frm = new frmLocClientes();
            frm.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
           
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            FrmLocVendedor frm = new FrmLocVendedor();
            frm.ShowDialog();
        }

        private void btnEstabelecimento_Click(object sender, EventArgs e)
        {
            FrmCadEstabelecimento frm = new FrmCadEstabelecimento();
            frm.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {

        }
    }
}

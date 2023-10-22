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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Base.Formularios
{
    public partial class FrmVendedor : Form
    {
        DateTime data = DateTime.Now;

        public FrmVendedor()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FrmVendedor fmr = new FrmVendedor();

        }



        private void cmdLimpar()
        {
            //btnNovo.Enabled = true;
            foreach (Control myControl in groupBox1.Controls)
            {
                if (myControl as TextBox == null)
                { }
                else
                {
                    ((TextBox)myControl).Text = "";
                }

                if (myControl as MaskedTextBox == null)
                { }
                else
                {
                    ((MaskedTextBox)myControl).Text = "";
                }
            }
            string DataFormato = data.ToString("d");
            maskData.Text = DataFormato;
            btnExcluir.Enabled = false;
            btnSalvar.Text = "Novo";
            txtId.Focus();
        }

        private void FrmVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtId.Text == "")
            {
                this.Close();
            }
            else
            {
                cmdLimpar();
            }
        }
    }
}

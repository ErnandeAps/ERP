
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace SuportekService
{
    public partial class FrmCadCliente : Form
    {
        string URI = "";
        DateTime data = DateTime.Now;
        
        public FrmCadCliente()
        {
            InitializeComponent();
            string DataFormato = data.ToString("d");
            maskData.Text = DataFormato;

        }

        private void btNovo_Click(object sender, EventArgs e)
        {

        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}

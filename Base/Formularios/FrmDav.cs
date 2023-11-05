using Erp;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base.Formularios;

namespace Base.Formularios
{
    public partial class FrmDav : Form
    {

        DateTime data = DateTime.Now;

        public FrmDav()
        {

            InitializeComponent();
        }


        private void relaçãoGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmDav_Load(object sender, EventArgs e)
        {
            lodDataGrid("");
        }

        public void lodDataGrid(string strSql)
        {

            Controls.Add(dtGrid);
            dtGrid.Size = new Size(697, 341);

            dtGrid.ColumnCount = 6;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Aqua;

            columnHeaderStyle.Font = new Font("Calibri", 8, FontStyle.Regular);
            dtGrid.EnableHeadersVisualStyles = false;
            dtGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGrid.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            dtGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            dtGrid.Columns[0].Name = "ID";
            dtGrid.Columns[1].Name = "IDPROD.";
            dtGrid.Columns[2].Name = "DESCRIÇÃO";
            dtGrid.Columns[3].Name = "VAL. UNIT";
            dtGrid.Columns[4].Name = "QUANT.";
            dtGrid.Columns[5].Name = "TOTAL.";

            dtGrid.Columns[0].Width = 40;
            dtGrid.Columns[1].Width = 60;
            dtGrid.Columns[2].Width = 248;
            dtGrid.Columns[3].Width = 100;
            dtGrid.Columns[4].Width = 70;
            dtGrid.Columns[5].Width = 100;

            dtGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dtGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            if (strSql == "")
            {
                strSql = "Select ID_ITENS_DAV,ID_PRODUTO,DESCRICAO, UNITARIO,QTD, TOTAL_PROD  from ITENS_DAV where ID_DAV>0";

            }
            else
            {
                dtGrid.Rows.Clear();
            }

            using (FbConnection conexaoFireBird = ConexaoFb.getInstancia().getConexao())
                try
                {
                    conexaoFireBird.Open();
                    FbCommand cmd = new FbCommand(strSql, conexaoFireBird);
                    FbDataReader Resultado = cmd.ExecuteReader();

                    if (Resultado.HasRows)
                    {
                        while (Resultado.Read())
                        {

                            dtGrid.Rows.Add(Resultado[0], Resultado[1], Resultado[2], Resultado[3]);

                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível se conectar ao banco");
                }
                finally
                {
                    //conexaoFireBird.Close();
                }
        }

        private void FrmDav_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void tsmFinalizar_Click(object sender, EventArgs e)
        {
            FrmFinDav frm = new FrmFinDav();
            frm.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            using (var frm = new frmLocClientes())
            {
                frm.Parametro = "";
                frm.ShowDialog();
                txtId.Text = frm.Parametro;
                maskData.Text = data.ToString();
            }

        }

        private void tsmNovo_Click(object sender, EventArgs e)
        {
            using (var frm = new frmLocClientes())
            {
                frm.Parametro = "";
                frm.ShowDialog();
                txtId.Text = frm.Parametro;
                maskData.Text = data.ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}

using Erp;
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

namespace Base.Formularios
{
    public partial class FrmLocDav : Form
    {
        public FrmLocDav()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public void lodDataGrid(string strSql)
        {

            Controls.Add(dtGrid);
            dtGrid.Size = new Size(787, 341);

            dtGrid.ColumnCount = 10;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Aqua;

            columnHeaderStyle.Font = new Font("Calibri", 8, FontStyle.Regular);
            dtGrid.EnableHeadersVisualStyles = false;
            dtGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGrid.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            dtGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            dtGrid.Columns[0].Name = "ID";
            dtGrid.Columns[1].Name = "IDCLIENTE";
            dtGrid.Columns[2].Name = "NOME";
            dtGrid.Columns[3].Name = "VENDEDOR";
            dtGrid.Columns[4].Name = "DATA";
            dtGrid.Columns[5].Name = "DESCONTO";
            dtGrid.Columns[6].Name = "TOTAL";
            dtGrid.Columns[7].Name = "FORMAPAG";
            dtGrid.Columns[8].Name = "NFE";
            dtGrid.Columns[9].Name = "OBS";

            dtGrid.Columns[0].Width = 50;
            dtGrid.Columns[1].Width = 80;
            dtGrid.Columns[2].Width = 180;
            dtGrid.Columns[3].Width = 150;
            dtGrid.Columns[9].Width = 200;

            dtGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dtGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dtGrid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtGrid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            if (strSql == "")
            {
                strSql = "Select ID_DAV,ID_CADASTRO,NOME,VENDEDOR,DATA, DESCONTO, TOTAL,FORMAPAG,NFE,OBS from DAV where ID_DAV>0";

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

                            dtGrid.Rows.Add(Resultado[0], Resultado[1], Resultado[2], Resultado[3], Resultado[4], Resultado[5], Resultado[6], Resultado[7], Resultado[8], Resultado[9]);

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

        private void FrmLocDav_Load(object sender, EventArgs e)
        {
            lodDataGrid("");
        }

        private void FrmLocDav_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FrmDav FRM = new FrmDav();
            FRM.Show();
        }
    }
}


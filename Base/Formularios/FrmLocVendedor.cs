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
    public partial class FrmLocVendedor : Form
    {
        public FrmLocVendedor()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FrmLocVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }



        public void lodDataGrid(string strSql)
        {

            Controls.Add(dtGrid);
            dtGrid.Size = new Size(787, 341);

            dtGrid.ColumnCount = 4;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Aqua;

            columnHeaderStyle.Font = new Font("Calibri", 8, FontStyle.Regular);
            dtGrid.EnableHeadersVisualStyles = false;
            dtGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGrid.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            dtGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            dtGrid.Columns[0].Name = "ID";
            dtGrid.Columns[1].Name = "NOME";
            dtGrid.Columns[2].Name = "CARGO";
            dtGrid.Columns[3].Name = "FONE";

            dtGrid.Columns[0].Width = 50;
            dtGrid.Columns[1].Width = 350;
            dtGrid.Columns[2].Width = 180;
            dtGrid.Columns[3].Width = 150;

            dtGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dtGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            if (strSql == "")
            {
                strSql = "Select ID_VENDEDOR, NOME CARGO, FONE from VENDEDOR where ID_VENDEDOR>0";

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

        private void FrmLocVendedor_Load(object sender, EventArgs e)
        {
            lodDataGrid("");
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FrmVendedor frm = new FrmVendedor();
            frm.ShowDialog();
        }
    }
}

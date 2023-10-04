using Erp;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erp
{
    public partial class frmLocClientes : Form
    {
                       
       public string strID_CADASTRO;
       public string Parametro
        {
            get { return strID_CADASTRO; }
        }
        
        public frmLocClientes()
        {
            InitializeComponent();
        }

        private void frmLocClientes_Load(object sender, EventArgs e)
        {
            loadCbTipo();
            lodDataGrid("");

        }

        public void loadCbTipo()
        {
            cbTipo.Items.Add("Cnpj/Cpf");
            cbTipo.Items.Add("Nome/Razão");
            cbTipo.Items.Add("Nome Fantisia");
            cbTipo.Items.Add("Endereço");
            cbTipo.Items.Add("Fone");
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTipo.Text)
            {
                case "Cnpj/Cpf":

                    break;
                case "Nome/Razão":

                    break;

                case "Nome Fantisia":

                    break;

                case "Endereço":

                    break;

                case "Fone":

                    break;

                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }

        public void lodDataGrid(string strSql)
        {

            Controls.Add(dtGrid);
            dtGrid.Size = new Size(986, 437);

            dtGrid.ColumnCount = 9;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Aqua;

            columnHeaderStyle.Font = new Font("Calibri", 8, FontStyle.Regular);
            dtGrid.EnableHeadersVisualStyles = false;
            dtGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGrid.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            dtGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            dtGrid.Columns[0].Name = "ID";
            dtGrid.Columns[1].Name = "CNPJ";
            dtGrid.Columns[2].Name = "RAZÃO SOCIAL";
            dtGrid.Columns[3].Name = "NOME FANTASIA";
            dtGrid.Columns[4].Name = "IE";
            dtGrid.Columns[5].Name = "ENDEREÇO";
            dtGrid.Columns[6].Name = "NÚM.";
            dtGrid.Columns[7].Name = "BAIRRO";
            dtGrid.Columns[8].Name = "CIDADE";


            dtGrid.Columns[0].Width = 50;
            dtGrid.Columns[1].Width = 150;
            dtGrid.Columns[2].Width = 220;
            dtGrid.Columns[3].Width = 220;
            dtGrid.Columns[4].Width = 100;
            dtGrid.Columns[5].Width = 220;
            dtGrid.Columns[6].Width = 50;
            dtGrid.Columns[7].Width = 150;
            dtGrid.Columns[8].Width = 150;

            dtGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dtGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dtGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGrid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dtGrid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGrid.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dtGrid.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            


            if (strSql== "")
            {
                strSql = "Select ID_CADASTRO, CGC, RAZAO, FANTASIA, IE, ENDER, NUMERO, BAIRRO, CIDADE from CADASTRO where ID_CADASTRO>0";

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

                        dtGrid.Rows.Add(Resultado[0], Resultado[1], Resultado[2], Resultado[3], Resultado[4], Resultado[5], Resultado[6], Resultado[7], Resultado[8]);

                    }
                }
            }catch(Exception)
            {
                MessageBox.Show("Não foi possível se conectar ao banco");
            }
                finally
                {
                    conexaoFireBird.Close();
                }
        }

        private void BtnPcnpj_Click(object sender, EventArgs e)
        {
          
        }

        private void dtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            strID_CADASTRO = dtGrid.CurrentRow.Cells[0].Value.ToString();
            

        }

        private void btSelecao_Click(object sender, EventArgs e)
        {
            
         
        }

        private void frmLocClientes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmCadCliente frm = new FrmCadCliente();
            frm.Show();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            strID_CADASTRO = dtGrid.CurrentRow.Cells[0].Value.ToString();
            Clientes clientes = new Clientes();
            //clientes = (Clientes)Funcoes_db.db_LocalizarDadosClientes(addfrm.Parametro);

            this.Close();
        }
    }
}

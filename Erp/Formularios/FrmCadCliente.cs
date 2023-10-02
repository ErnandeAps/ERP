
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
using Correios;


namespace Erp
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

        

        private void BtnPcnpj_Click(object sender, EventArgs e)
        {
            if (cbTipo.Text == "CNPJ")
            {
                ConsultarCnpj();
                

            }
            else
            {
                if (FuncoesDiversas.ValidaCPF.IsCpf(maskCnpjCpf.Text))
                {
                    maskCnpjCpf.Text = FuncoesDiversas.FormatCPF(maskCnpjCpf.Text);
                    txtNome.Focus();
                }else
                {
                    MessageBox.Show("Não foi possível validar o CPF : " + maskCnpjCpf.Text);
                }
            }    
        }

        private async void ConsultarCnpj()
        {
            string strCnpj = FuncoesDiversas.SemFormatacao(maskCnpjCpf.Text);
            URI = "https://www.receitaws.com.br/v1/cnpj/" + strCnpj;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                       
                        var JsonString = await response.Content.ReadAsStringAsync();
                        Clientes empresa = Newtonsoft.Json.JsonConvert.DeserializeObject<Clientes>(JsonString);

                        try
                        {
                            maskCnpjCpf.Text = empresa.Cnpj;
                            txtNome.Text = empresa.Nome;
                            txtFantasia.Text = empresa.Fantasia;
                            txtEnd.Text = empresa.Logradouro;
                            txtNum.Text = empresa.Numero;
                            txtEnd.Text = empresa.Logradouro;
                            txtBairro.Text = empresa.Bairro;
                            txtCidade.Text = empresa.Municipio;
                            txtUf.Text = empresa.Uf;
                            txtCep.Text = empresa.Cep;
                            txtEmail.Text = empresa.Email;

                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o CNPJ : " + response.StatusCode);
                    }
                }
            }
        }

        private void cbTipop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipo.Text =="CNPJ")
            {
                maskCnpjCpf.Mask = "99,999,999/9999-99";
            }
            else
            {
                maskCnpjCpf.Mask = "999,999,999-99";
            }
            maskCnpjCpf.Focus();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void btCep_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCep.Text))
                MessageBox.Show("O campo Cep estar vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
            {
                try
                {
                    /*
                    CorreiosApi correiosapi = new CorreiosApi();
                    var retorno = correiosapi.consultaCEP(txtCep.Text);
                    
                    txtEnd.Text = retorno.end;
                    txtBairro.Text = retorno.bairro;
                    txtCidade.Text = retorno.cidade;
                    txtUf.Text = retorno.uf;
                    txtNum.Focus();
                    */
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Cep não encontrado " + erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            try
            {
             
                switch (btNovo.Text)
                {
                case "Novo":
                    
                        cmdLimpar();
                        btNovo.Text = "Salvar";
                        cbTipo.Focus();
                        
                        break;

                case "Salvar":
                                                
                        Funcoes_db.db_InserirDados((Clientes)loadClientes());
                        MessageBox.Show("Registro inserido com sucesso !", "Inserir", MessageBoxButtons.OK);
                        cmdLimpar();
                        break;

                case "Atualizar":
                                               
                        Funcoes_db.db_AlterarDados((Clientes)loadClientes());
                        MessageBox.Show("Registro atualizado com sucesso !", "Atualizar", MessageBoxButtons.OK);
                        cmdLimpar();
                        break;
                }      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
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
            btExcluir.Enabled = false;
            btNovo.Text = "Novo";
            txtId.Focus();
        }
        
        private void btLocalizar_Click(object sender, EventArgs e)
        {
            /*
            Clientes clientes = new Clientes();
            frmLocClientes addfrm = new frmLocClientes();

            addfrm.ShowDialog();
            if (addfrm.Parametro == null)
                cmdLimpar();
            else
            {
                
                clientes = (Clientes)Funcoes_db.db_LocalizarDadosClientes(addfrm.Parametro);
                preencheDados(clientes);
                btNovo.Text = "Atualizar";
                btExcluir.Enabled = true;
            }
            */
        }

        private void preencheDados(Clientes cli)
        {
            cmdLimpar();
            txtId.Text = cli.ID.ToString();
            cbTipo.Text = cli.Tipo;
            maskCnpjCpf.Text = cli.Cnpj;
            txtNome.Text = cli.Nome;
            txtFantasia.Text = cli.Fantasia;
            txtEnd.Text = cli.Logradouro;
            txtNum.Text = cli.Numero;
            txtBairro.Text = cli.Bairro;
            txtCidade.Text = cli.Municipio;
            txtUf.Text = cli.Uf;
            txtCep.Text = cli.Cep;
            txtEmail.Text = cli.Email;
            txtContato.Text = cli.Contato;
            maskFone.Text = cli.Telefone;
            maskCelular.Text = cli.Celular;
            txtRoteiro.Text = cli.Roteiro;
        }


        private void btSair_Click(object sender, EventArgs e)
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

        private void btExcluir_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtId.Text);
            try
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir este registro?", "Assistente de exclesão", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Funcoes_db.db_ExcluirDados((Clientes)loadClientes());
                    MessageBox.Show("Registro excluído com sucesso !", "Alterar", MessageBoxButtons.OK);
                    cmdLimpar();
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private Object loadClientes()
        {
            Clientes clientes = new Clientes();
            if (txtId.Text!="")
                clientes.ID = Convert.ToInt32(txtId.Text);
            
            clientes.Tipo = cbTipo.Text;
            clientes.Cnpj = maskCnpjCpf.Text;
            clientes.Nome = txtNome.Text;
            clientes.Fantasia = txtFantasia.Text;
            clientes.Logradouro = txtEnd.Text;
            clientes.Numero = txtNum.Text;
            clientes.Bairro = txtBairro.Text;
            clientes.Municipio = txtCidade.Text;
            clientes.Uf = txtUf.Text;
            clientes.Cep = txtCep.Text;
            clientes.Email = txtEmail.Text;
            clientes.Contato = txtContato.Text;
            clientes.Telefone = maskFone.Text;
            clientes.Celular = maskCelular.Text;
            clientes.Data = maskData.Text;
            clientes.Roteiro = txtRoteiro.Text;
            return clientes;
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                switch (btNovo.Text)
                {
                    case "Novo":

                        cmdLimpar();
                        btNovo.Text = "Salvar";
                        cbTipo.Focus();

                        break;

                    case "Salvar":
                        if (txtNome.Text=="")
                        {
                            MessageBox.Show("Obrigatório o preenchimento do Nome do Cliente.", "Alterar", MessageBoxButtons.OK);
                        }
                        else
                        {
                            Funcoes_db.db_InserirDados((Clientes)loadClientes());
                            MessageBox.Show("Registro inserido com sucesso !", "Inserir", MessageBoxButtons.OK);
                            cmdLimpar();
                        } 
                        
                        break;

                    case "Atualizar":
                        if (txtNome.Text == "")
                        {
                            MessageBox.Show("Obrigatório o preenchimento do Nome do Cliente.", "Alterar", MessageBoxButtons.OK);
                        }
                        else
                        {
                            Funcoes_db.db_AlterarDados((Clientes)loadClientes());
                            MessageBox.Show("Registro atualizado com sucesso !", "Atualizar", MessageBoxButtons.OK);
                            cmdLimpar();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void localizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            Clientes clientes = new Clientes();
            frmLocClientes addfrm = new frmLocClientes();

            addfrm.ShowDialog();
            if (addfrm.Parametro == null)
                cmdLimpar();
            else
            {
                
                clientes = (Clientes)Funcoes_db.db_LocalizarDadosClientes(addfrm.Parametro);
                preencheDados(clientes);
                btNovo.Text = "Atualizar";
                btExcluir.Enabled = true;
            }
            */
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int codigo = Convert.ToInt32(txtId.Text);
            try
            {
               if(txtId.Text=="")
                {
                    MessageBox.Show("Consulte um cliente para continuar.", "Alterar", MessageBoxButtons.OK);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir este registro?", "Assistente de exclesão", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Funcoes_db.db_ExcluirDados((Clientes)loadClientes());
                        MessageBox.Show("Registro excluído com sucesso !", "Alterar", MessageBoxButtons.OK);
                        cmdLimpar();
                    }
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void FrmCadCliente_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Escape:
                    //sairToolStripMenuItem_Click(sender, e);
                    this.Close();
                    break;

                case Keys.F2:
                    novoToolStripMenuItem_Click(sender, e);
                    break;

                case Keys.F3:
                    salvarToolStripMenuItem_Click(sender, e);
                    break;

                case Keys.F6:
                    excluirToolStripMenuItem_Click(sender, e);
                    break;

            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                switch (btNovo.Text)
                {
                    case "Novo":

                        cmdLimpar();
                        btNovo.Text = "Salvar";
                        cbTipo.Focus();

                        break;

                    case "Salvar":
                        if (txtNome.Text == "")
                        {
                            MessageBox.Show("Obrigatório o preenchimento do Nome do Cliente.", "Alterar", MessageBoxButtons.OK);
                        }
                        else
                        {
                            Funcoes_db.db_InserirDados((Clientes)loadClientes());
                            MessageBox.Show("Registro inserido com sucesso !", "Inserir", MessageBoxButtons.OK);
                            cmdLimpar();
                        }

                        break;

                    case "Atualizar":
                        if (txtNome.Text == "")
                        {
                            MessageBox.Show("Obrigatório o preenchimento do Nome do Cliente.", "Alterar", MessageBoxButtons.OK);
                        }
                        else
                        {
                            Funcoes_db.db_AlterarDados((Clientes)loadClientes());
                            MessageBox.Show("Registro atualizado com sucesso !", "Atualizar", MessageBoxButtons.OK);
                            cmdLimpar();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {

        }
    }
    
}

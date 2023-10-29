using System.Text.Json;
using Base.Data;
using Base.ExternalApis;
using Base.Funcoes;
using Base.Repository.ClienteRepository;

namespace Base.Formularios
{
    public partial class FrmCadCliente : Form
    {
        private readonly IClienteRepository repository;
        private readonly IReceitaApi receitaApi;
        
        string URI = "";
        public string strID_CADASTRO;

        public DialogResult ShowDialog(string clienteId)
        {
            strID_CADASTRO = clienteId;
            string DataFormato = DateTime.Now.ToString("d");
            maskData.Text = DataFormato;
            loadCadastro();
            return ShowDialog();
        }

        public FrmCadCliente(IClienteRepository repository, IReceitaApi receitaApi)
        {
            this.repository = repository;
            this.receitaApi = receitaApi;
            InitializeComponent();
        }

        private void BtnPcnpj_Click(object sender, EventArgs e)
        {
            if (cbTipo.Text == "CNPJ")
            {
                ConsultarCnpj();
                return;
            }

            if (FuncoesDiversas.ValidaCPF.IsCpf(maskCnpjCpf.Text))
            {
                maskCnpjCpf.Text = FuncoesDiversas.FormatCPF(maskCnpjCpf.Text);
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Não foi possível validar o CPF : " + maskCnpjCpf.Text);
            }
            
        }

        private async void ConsultarCnpj()
        {
            string strCnpj = FuncoesDiversas.SemFormatacao(maskCnpjCpf.Text);
            var receitaResponse = await receitaApi.ConsultarCNPJ(strCnpj);
            if (receitaResponse is { IsSuccessStatusCode: false, Content: not null })
            {
                MessageBox.Show("Não foi possível obter o CNPJ : " + receitaResponse.StatusCode);
            }

            var empresa = receitaResponse.Content;
            maskCnpjCpf.Text = empresa.CGC;
            txtNome.Text = empresa.NOME ;
            txtFantasia.Text = empresa.FANTASIA;
            txtEnd.Text = empresa.LOGRADOURO;
            txtNum.Text = empresa.NUMERO;        
            txtBairro.Text = empresa.BAIRRO;
            txtCidade.Text = empresa.MUNICIPIO ;
            txtUf.Text = empresa.UF;
            txtCep.Text = empresa.CEP;
            txtEmail.Text = empresa.EMAIL;
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
             
                switch (btnSalvar.Text)
                {
                    case "Novo":
                        cmdLimpar();
                        btnSalvar.Text = "Salvar";
                        cbTipo.Focus();
                        break;

                    case "Salvar":
                        Funcoes_db.db_InserirDados(LoadClienteFromForm());
                        MessageBox.Show("Registro inserido com sucesso !", "Inserir", MessageBoxButtons.OK);
                        cmdLimpar();
                        break;

                    case "Atualizar":
                        Funcoes_db.db_AlterarDados(LoadClienteFromForm());
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
            string DataFormato = DateTime.Now.ToString("d");
            maskData.Text = DataFormato;
            btnExcluir.Enabled = false;
            btnSalvar.Text = "Novo";
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

        private void preencheDados(Cliente cli)
        {
            cmdLimpar();
            txtId.Text = cli.ID_CADASTRO.ToString();
            //cbTipo.Text = cli.ATIVO;
            maskCnpjCpf.Text = cli.CGC;
            txtNome.Text = cli.NOME;
            txtFantasia.Text = cli.FANTASIA;
            txtEnd.Text = cli.LOGRADOURO ;
            txtNum.Text = cli.NUMERO;
            txtBairro.Text = cli.BAIRRO;
            txtCidade.Text = cli.MUNICIPIO ;
            txtUf.Text = cli.UF;
            txtCep.Text = cli.CEP;
            txtEmail.Text = cli.EMAIL;
            txtContato.Text = cli.CONTATO;
            maskFone.Text = cli.FONE;
            maskCelular.Text = cli.CELULAR;
            txtRoteiro.Text = cli.OBS;
        }


        private void btSair_Click(object sender, EventArgs e)
        {
           
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtId.Text);
            try
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir este registro?", "Assistente de exclesão", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Funcoes_db.db_ExcluirDados(LoadClienteFromForm());
                    MessageBox.Show("Registro excluído com sucesso !", "Alterar", MessageBoxButtons.OK);
                    cmdLimpar();
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private Cliente LoadClienteFromForm()
        {
            Cliente cliente = new Cliente();
            if (txtId.Text!="")
                cliente.ID_CADASTRO = Convert.ToInt32(txtId.Text);
            
            //clientes.ATIVO = cbTipo.Text;
            cliente.CGC = maskCnpjCpf.Text;
            cliente.NOME  = txtNome.Text;
            cliente.FANTASIA = txtFantasia.Text;
            cliente.LOGRADOURO  = txtEnd.Text;
            cliente.NUMERO = txtNum.Text;
            cliente.BAIRRO = txtBairro.Text;
            cliente.MUNICIPIO  = txtCidade.Text;
            cliente.UF = txtUf.Text;
            cliente.CEP = txtCep.Text;
            cliente.EMAIL = txtEmail.Text;
            cliente.CONTATO = txtContato.Text;
            cliente.FONE = maskFone.Text;
            cliente.CELULAR = maskCelular.Text;
            // clientes.CADASTRO = maskData.Text;
            cliente.OBS = txtRoteiro.Text;
            return cliente;
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                switch (btnSalvar.Text)
                {
                    case "Novo":
                        cmdLimpar();
                        btnSalvar.Text = "Salvar";
                        cbTipo.Focus();
                        break;

                    case "Salvar":
                        if (txtNome.Text=="")
                        {
                            MessageBox.Show("Obrigatório o preenchimento do Nome do Cliente.", "Alterar", MessageBoxButtons.OK);
                        }
                        else
                        {
                            Funcoes_db.db_InserirDados(LoadClienteFromForm());
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
                            Funcoes_db.db_AlterarDados(LoadClienteFromForm());
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
                        Funcoes_db.db_ExcluirDados(LoadClienteFromForm());
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

                switch (btnSalvar.Text)
                {
                    case "Novo":

                        cmdLimpar();
                        btnSalvar.Text = "Salvar";
                        cbTipo.Focus();

                        break;

                    case "Salvar":
                        if (txtNome.Text == "")
                        {
                            MessageBox.Show("Obrigatório o preenchimento do Nome do Cliente.", "Alterar", MessageBoxButtons.OK);
                        }
                        else
                        {
                            Funcoes_db.db_InserirDados(LoadClienteFromForm());
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
                            Funcoes_db.db_AlterarDados(LoadClienteFromForm());
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtId.Text);
            try
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir este registro?", "Assistente de exclesão", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Funcoes_db.db_ExcluirDados(LoadClienteFromForm());
                    MessageBox.Show("Registro excluído com sucesso !", "Alterar", MessageBoxButtons.OK);
                    cmdLimpar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == "")
                {
                    MessageBox.Show("Obrigatório o preenchimento do Nome do Cliente.", "Alterar", MessageBoxButtons.OK);
                }
                else
                {
                    if (txtId.Text =="")
                    {
                        var result = await repository.SalvarCliente(LoadClienteFromForm());
                        MessageBox.Show("Registro inserido com sucesso !", "Inserir", MessageBoxButtons.OK);
                    }
                    else
                    {
                        Funcoes_db.db_AlterarDados(LoadClienteFromForm());
                        MessageBox.Show("Registro atualizado com sucesso !", "Atualizar", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void loadCadastro()
        {
            if (strID_CADASTRO=="")
            {
                cmdLimpar();
            }
            else
            {
                Cliente cliente = new Cliente();
                cliente = (Cliente)Funcoes_db.db_LocalizarDadosClientes(strID_CADASTRO);
                preencheDados(cliente);
                //btNovo.Text = "Atualizar";
                //btExcluir.Enabled = true;
               
            }
        }
    }
}
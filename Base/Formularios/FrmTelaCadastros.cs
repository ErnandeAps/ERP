namespace Base.Formularios
{
    public partial class FrmTelaCadastros : Form
    {
        private readonly FrmCadCliente formCadCliente;
     
        public FrmTelaCadastros(FrmCadCliente formCadCliente)
        {
            this.formCadCliente = formCadCliente;
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            formCadCliente.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            /*
             // Cria as variáveis de execução comando e controle de transação
             FbCommand connQuery = new FbCommand();
             FbTransaction transaction;
             // Inicia a transação local
             transaction = connInfotech.BeginTransaction();
             // Atribui a conexão e a transação ao comando
             connQuery.Connection = connInfotech;
             connQuery.Transaction = transaction;
             connQuery.CommandText = "SELECT * FROM TB_CIDADES";
             //Cria um reader, isso deve ser usado para ler os dados???
             FbDataReader dtreQuery = connQuery.ExecuteReader();
             // Pégua o número de registros localizados
             Console.WriteLine(dtreQuery.FieldCount);
             // Encerra o comando e a conexão
             dtreQuery.Close();
             connInfotech.Close();
             Console.WriteLine(">>");
            */
        }
    }
}
using Base.Data;
using FirebirdSql.Data.FirebirdClient;

namespace Base.Funcoes
{
    class Funcoes_db
    {
        /*
        public static void db_InserirDados(Modelo modelo)
        {
            {
                try
                {
                    string mSQL = "INSERT into tbmodelo (modelo, marca) Values('" + modelo.modelo  + "','" + modelo.marca  + "')";
                    MySqlCommand cmd = new MySqlCommand(mSQL, Conexao.AbrirConexao());
                    cmd.ExecuteNonQuery();

                }
                catch (Exception fbex)
                {

                    throw fbex;
                }
                finally
                {
                    Conexao.FecharConexao();
                }
            }
        }
        public static void db_InserirDados(Marca marca)
        {
            {
                try
                {
                    string mSQL = "INSERT into tbmarca (descricao) Values('" +  marca.descricao + "')";
                    MySqlCommand cmd = new MySqlCommand(mSQL, Conexao.AbrirConexao());
                    cmd.ExecuteNonQuery();

                }
                catch (Exception fbex)
                {

                    throw fbex;
                }
                finally
                {
                    Conexao.FecharConexao();
                }
            }
        }
        */

        public static void db_InserirDados(Cliente cliente)
        {
            {
                try
                {
                    string mSQL = "INSERT into clientes (tipo, Cnpj, Nome, Fantasia, Logradouro, Numero, Bairro, Municipio, Uf, Cep, Email, Contato," +
                    " Telefone, Celular, Data, Roteiro) Values('" + cliente.ATIVO + "','" + cliente.CGC + "','" + cliente.NOME + "','" + cliente.FANTASIA + "','" + 
                    cliente.LOGRADOURO  + "','" + cliente.NUMERO + "','" + cliente.BAIRRO + "','" + cliente.MUNICIPIO  + "','" + cliente.UF + "','" + 
                    cliente.CEP + "','" + cliente.EMAIL + "','" + cliente.CONTATO + "','" + cliente.FONE + "','" + cliente.CELULAR + "','" + 
                    cliente.CADASTRO + "','" + cliente.OBS + "')";
                   // MySqlCommand cmd = new MySqlCommand(mSQL,Conexao.AbrirConexao());
                   // cmd.ExecuteNonQuery();
                    
                }
                catch (Exception fbex)
                {
                    
                    throw fbex;
                }
                finally
                {
                    //Conexao.FecharConexao();
                }
            }
        }

        /*
        public static void db_InserirDados(Fornecedor  fornecedor)
        {
            {
                try
                {
                    string mSQL = "INSERT into fornecedores (tipo, Cnpj, Nome, Fantasia, Logradouro, Numero, Bairro, Municipio, Uf, Cep, Email, Contato," +
                    " Telefone, Celular, Data, Roteiro) Values('" + fornecedor.Tipo + "','" + fornecedor.Cnpj + "','" + fornecedor.Nome + "','" + fornecedor.Fantasia + "','" +
                    fornecedor.Logradouro + "','" + fornecedor.Numero + "','" + fornecedor.Bairro + "','" + fornecedor.Municipio + "','" + fornecedor.Uf + "','" +
                    fornecedor.Cep + "','" + fornecedor.Email + "','" + fornecedor.Contato + "','" + fornecedor.Telefone + "','" + fornecedor.Celular + "','" +
                    fornecedor.Data + "','" + fornecedor.Roteiro + "')";
                    MySqlCommand cmd = new MySqlCommand(mSQL, Conexao.AbrirConexao());
                    cmd.ExecuteNonQuery();

                }
                catch (Exception fbex)
                {

                    throw fbex;
                }
                finally
                {
                    Conexao.FecharConexao();
                }
            }
        }

        public static void db_AlterarDados(Fornecedor fornecedor)
        {
            {
                try
                {  
                    string mSQL = "UPDATE fornecedores SET tipo='" + fornecedor.Tipo + "', cnpj='" + fornecedor.Cnpj + "', Nome='" + fornecedor.Nome + "', Fantasia='" + fornecedor.Fantasia + "'," +
                    "Logradouro='" + fornecedor.Logradouro + "', Numero='" + fornecedor.Numero + "', Bairro='" + fornecedor.Bairro + "', Municipio='" + fornecedor.Municipio + "'," +
                    "Uf='" + fornecedor.Uf + "', Cep='" + fornecedor.Cep + "', Email='" + fornecedor.Email + "', Contato='" + fornecedor.Contato + "', Telefone='" + fornecedor.Telefone + "'," +
                    "Celular='" + fornecedor.Celular + "', Roteiro='" + fornecedor.Roteiro + "' WHERE id=" + fornecedor.ID +"";
                    
                    MySqlCommand cmd = new MySqlCommand(mSQL, Conexao.AbrirConexao());
                    cmd.ExecuteNonQuery();

                }
                catch (Exception fbex)
                {

                    throw fbex;
                }
                finally
                {
                    Conexao.FecharConexao();
                }
            }
        }

        public static object db_LocalizarDadosFornecedores(string id)
        {

            string mSQL = "SELECT * FROM fornecedores where id=" + id + "";

            MySqlCommand cmd = new MySqlCommand(mSQL, Conexao.AbrirConexao());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            Fornecedor fornecedor = new Fornecedor();
            fornecedor.ID = Convert.ToInt32(dataTable.Rows[0]["id"].ToString());
            fornecedor.Tipo = dataTable.Rows[0]["tipo"].ToString();
            fornecedor.Cnpj = dataTable.Rows[0]["cnpj"].ToString();
            fornecedor.Nome = dataTable.Rows[0]["nome"].ToString();
            fornecedor.Fantasia = dataTable.Rows[0]["fantasia"].ToString();
            fornecedor.Logradouro = dataTable.Rows[0]["logradouro"].ToString();
            fornecedor.Numero = dataTable.Rows[0]["numero"].ToString();
            fornecedor.Bairro = dataTable.Rows[0]["bairro"].ToString();
            fornecedor.Municipio = dataTable.Rows[0]["municipio"].ToString();
            fornecedor.Uf = dataTable.Rows[0]["uf"].ToString();
            fornecedor.Cep = dataTable.Rows[0]["cep"].ToString();
            fornecedor.Email = dataTable.Rows[0]["email"].ToString();
            fornecedor.Contato = dataTable.Rows[0]["contato"].ToString();
            fornecedor.Telefone = dataTable.Rows[0]["telefone"].ToString();
            fornecedor.Celular = dataTable.Rows[0]["celular"].ToString();
            fornecedor.Data = dataTable.Rows[0]["data"].ToString();
            fornecedor.Roteiro = dataTable.Rows[0]["roteiro"].ToString();

            Conexao.FecharConexao();
            return fornecedor;
        }

        public static string db_ExcluirDados(Fornecedor fornecedor)
        {
            try
            {

                string mSQL = "DELETE FROM fornecedores WHERE id=" + fornecedor.ID;
                MySqlCommand cmd = new MySqlCommand(mSQL, Conexao.AbrirConexao());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Conexao.FecharConexao();
            }
            return "Ok";
        }
        */

        public static void db_AlterarDados(Cliente cliente)
        {
            {
                try
                {  
                    string mSQL = "UPDATE clientes SET tipo='" + cliente.ATIVO + "', cnpj='" + cliente.CGC + "', Nome='" + cliente.NOME + "', Fantasia='" + cliente.FANTASIA + "'," +
                    "Logradouro='" + cliente.LOGRADOURO  + "', Numero='" + cliente.NUMERO + "', Bairro='" + cliente.BAIRRO + "', Municipio='" + cliente.MUNICIPIO  + "'," +
                    "Uf='" + cliente.UF + "', Cep='" + cliente.CEP + "', Email='" + cliente.EMAIL + "', Contato='" + cliente.CONTATO + "', Telefone='" + cliente.FONE + "'," +
                    "Celular='" + cliente.CELULAR + "', Roteiro='" + cliente.OBS + "' WHERE id=" + cliente.ID_CADASTRO +"";
                    
                    //MySqlCommand cmd = new MySqlCommand(mSQL, Conexao.AbrirConexao());
                    //cmd.ExecuteNonQuery();

                }
                catch (Exception fbex)
                {

                    throw fbex;
                }
                finally
                {
                    //Conexao.FecharConexao();
                }
            }
        }

        



        public static object db_LocalizarDadosClientes(string id)
        {
            //string mSQL = "Select * from CADASTRO where ID_CADASTRO=" + id + "";
            string mSQL = "Select ID_CADASTRO, CGC, RAZAO, FANTASIA, IE, ENDER, NUMERO, BAIRRO, CIDADE from CADASTRO where ID_CADASTRO>0";
            Cliente cliente = new Cliente();
            using (FbConnection conexaoFireBird = ConexaoFb.getInstancia().getConexao())

                try
                {
                    conexaoFireBird.Open();
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataReader Resultado = cmd.ExecuteReader();
                    

                    if (Resultado.HasRows)
                    {
                        int num;                        //clientes.ID_CADASTRO = Convert.ToInt32(Resultado[0]["ID_CADASTRO"].ToString());
                        num = Convert.ToInt32(Resultado[0]);
                        //dtGrid.Rows.Add(Resultado[0], Resultado[1], Resultado[2], Resultado[3], Resultado[4], Resultado[5], Resultado[6], Resultado[7], Resultado[8]);

                    }
                   

                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível se conectar ao banco");
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            return cliente;

            /*
           adapter.Fill(dataTable);
           clientes.ID_CADASTRO = Convert.ToInt32(dataTable.Rows[0]["ID_CADASTRO"].ToString());
           clientes.ATIVO = dataTable.Rows[0]["ATIVO"].ToString();
           clientes.CGC = dataTable.Rows[0]["CGC"].ToString();
           clientes.RAZAO = dataTable.Rows[0]["RAZAO"].ToString();
           clientes.FANTASIA = dataTable.Rows[0]["FANTANSIA"].ToString();
           clientes.ENDER = dataTable.Rows[0]["ENDER"].ToString();
           clientes.NUMERO = dataTable.Rows[0]["NUMERO"].ToString();
           clientes.BAIRRO = dataTable.Rows[0]["BAIRRO"].ToString();
           clientes.CIDADE = dataTable.Rows[0]["CIDADE"].ToString();

            * conexaoFireBird.Open();
            FbCommand cmd = new FbCommand(mSQL);
            FbDataAdapter adapter = new FbDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            Clientes clientes = new Clientes();
            clientes.UF = dataTable.Rows[0]["UF"].ToString();
            clientes.CEP = dataTable.Rows[0]["CEP"].ToString();
            clientes.EMAIL = dataTable.Rows[0]["EMAIL"].ToString();
            clientes.CONTATO = dataTable.Rows[0]["CONATO"].ToString();
            clientes.FONE = dataTable.Rows[0]["FONE"].ToString();
            clientes.CELULAR = dataTable.Rows[0]["CELULAR"].ToString();
            clientes.CADASTRO = dataTable.Rows[0]["CADASTRO"].ToString();
            clientes.OBS = dataTable.Rows[0]["OBS"].ToString();
           */


        }
        /*
        string mSQL ="SELECT * FROM CADASTRO where ID_CADASTRO=" + id + "";
        using (FbConnection conexaoFireBird = ConexaoFb.getInstancia().getConexao())

                conexaoFireBird.Open();
                FbCommand cmd = new FbCommand(mSQL,);
                //FbDataReader Resultado = cmd.ExecuteReader();
                FbDataAdapter adapter = new FbDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                Clientes clientes = new Clientes();
                clientes.ID_CADASTRO = Convert.ToInt32(dataTable.Rows[0]["ID_CADASTRO"].ToString());
                clientes.ATIVO = dataTable.Rows[0]["ATIVO"].ToString();
                clientes.CGC = dataTable.Rows[0]["CGC"].ToString();
                clientes.RAZAO = dataTable.Rows[0]["RAZAO"].ToString();
                clientes.FANTASIA = dataTable.Rows[0]["FANTANSIA"].ToString();
                clientes.ENDER = dataTable.Rows[0]["ENDER"].ToString();
                clientes.NUMERO = dataTable.Rows[0]["NUMERO"].ToString();
                clientes.BAIRRO = dataTable.Rows[0]["BAIRRO"].ToString();
                clientes.CIDADE = dataTable.Rows[0]["CIDADE"].ToString();
                clientes.UF = dataTable.Rows[0]["UF"].ToString();
                clientes.CEP = dataTable.Rows[0]["CEP"].ToString();
                clientes.EMAIL = dataTable.Rows[0]["EMAIL"].ToString();
                clientes.CONTATO = dataTable.Rows[0]["CONATO"].ToString();
                clientes.FONE = dataTable.Rows[0]["FONE"].ToString();
                clientes.CELULAR = dataTable.Rows[0]["CELULAR"].ToString();
                clientes.CADASTRO = dataTable.Rows[0]["CADASTRO"].ToString();
                clientes.OBS = dataTable.Rows[0]["OBS"].ToString();

        conexaoFireBird.Close();
          */

        //conexaoFireBird.Open();
        //FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
        // FbDataReader Resultado = cmd.ExecuteReader();
        /*
        MySqlCommand cmd = new MySqlCommand(mSQL, Conexao.AbrirConexao()); 
        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
        */
        //DataTable dataTable = new DataTable();
        //adapter.Fill(dataTable);
        /*
        Clientes clientes = new Clientes();
        clientes.ID_CADASTRO = Convert.ToInt32( dataTable.Rows[0]["ID_CADASTRO"].ToString());
        clientes.ATIVO = dataTable.Rows[0]["ATIVO"].ToString();
        clientes.CGC = dataTable.Rows[0]["CGC"].ToString();
        clientes.RAZAO = dataTable.Rows[0]["RAZAO"].ToString();
        clientes.FANTASIA = dataTable.Rows[0]["FANTANSIA"].ToString();
        clientes.ENDER = dataTable.Rows[0]["ENDER"].ToString();
        clientes.NUMERO = dataTable.Rows[0]["NUMERO"].ToString();
        clientes.BAIRRO = dataTable.Rows[0]["BAIRRO"].ToString();
        clientes.CIDADE = dataTable.Rows[0]["CIDADE"].ToString();
        clientes.UF = dataTable.Rows[0]["UF"].ToString();
        clientes.CEP = dataTable.Rows[0]["CEP"].ToString();
        clientes.EMAIL = dataTable.Rows[0]["EMAIL"].ToString();
        clientes.CONTATO = dataTable.Rows[0]["CONATO"].ToString();
        clientes.FONE = dataTable.Rows[0]["FONE"].ToString();
        clientes.CELULAR = dataTable.Rows[0]["CELULAR"].ToString();
        clientes.CADASTRO = dataTable.Rows[0]["CADASTRO"].ToString();
        clientes.OBS = dataTable.Rows[0]["OBS"].ToString();

        //Conexao.FecharConexao();
        */
        //return clientes;

    

        
        /*
        public static string db_ExcluirDadosMarca(Modelo modelo)
        {
            try
            {

                string mSQL = "DELETE FROM tbmodelo WHERE id=" + modelo.ID;
                MySqlCommand cmd = new MySqlCommand(mSQL, Conexao.AbrirConexao());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Conexao.FecharConexao();
            }
            return "Ok";
        }
        public static string db_ExcluirDadosMarca(Marca marca)
        {
            try
            {

                string mSQL = "DELETE FROM tbmarca WHERE id=" + marca.ID;
                MySqlCommand cmd = new MySqlCommand(mSQL, Conexao.AbrirConexao());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Conexao.FecharConexao();
            }
            return "Ok";
        }
        */

        public static string db_ExcluirDados(Cliente cliente)
        {
            try
            {
                
                string mSQL = "DELETE FROM clientes WHERE id=" + cliente.ID_CADASTRO;
                //MySqlCommand cmd = new MySqlCommand(mSQL, Conexao.AbrirConexao());
               // cmd.ExecuteNonQuery();
            }catch(Exception e)
            {
                throw e;
            }
            finally
            {
               // Conexao.FecharConexao();
            }
            return "Ok";
        }

        

    }
}

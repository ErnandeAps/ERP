using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Windows.Forms;
using System.Data.SqlClient;

namespace Erp
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

        public static void db_InserirDados(Clientes clientes)
        {
            {
                try
                {
                    string mSQL = "INSERT into clientes (tipo, Cnpj, Nome, Fantasia, Logradouro, Numero, Bairro, Municipio, Uf, Cep, Email, Contato," +
                    " Telefone, Celular, Data, Roteiro) Values('" + clientes.ATIVO + "','" + clientes.CGC + "','" + clientes.RAZAO + "','" + clientes.FANTASIA + "','" + 
                    clientes.ENDER + "','" + clientes.NUMERO + "','" + clientes.BAIRRO + "','" + clientes.CIDADE + "','" + clientes.UF + "','" + 
                    clientes.CEP + "','" + clientes.EMAIL + "','" + clientes.CONTATO + "','" + clientes.FONE + "','" + clientes.CELULAR + "','" + 
                    clientes.CADASTRO + "','" + clientes.OBS + "')";
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

        public static void db_AlterarDados(Clientes clientes)
        {
            {
                try
                {  
                    string mSQL = "UPDATE clientes SET tipo='" + clientes.ATIVO + "', cnpj='" + clientes.CGC + "', Nome='" + clientes.RAZAO + "', Fantasia='" + clientes.FANTASIA + "'," +
                    "Logradouro='" + clientes.ENDER + "', Numero='" + clientes.NUMERO + "', Bairro='" + clientes.BAIRRO + "', Municipio='" + clientes.CIDADE + "'," +
                    "Uf='" + clientes.UF + "', Cep='" + clientes.CEP + "', Email='" + clientes.EMAIL + "', Contato='" + clientes.CONTATO + "', Telefone='" + clientes.FONE + "'," +
                    "Celular='" + clientes.CELULAR + "', Roteiro='" + clientes.OBS + "' WHERE id=" + clientes.ID_CADASTRO +"";
                    
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

            string mSQL ="SELECT * FROM clientes where id=" + id + "";
            /*
            MySqlCommand cmd = new MySqlCommand(mSQL, Conexao.AbrirConexao()); 
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            */
            DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            Clientes clientes = new Clientes();
            clientes.ID_CADASTRO = Convert.ToInt32( dataTable.Rows[0]["id"].ToString());
            clientes.ATIVO = dataTable.Rows[0]["tipo"].ToString();
            clientes.CGC = dataTable.Rows[0]["cnpj"].ToString();
            clientes.RAZAO = dataTable.Rows[0]["nome"].ToString();
            clientes.FANTASIA = dataTable.Rows[0]["fantasia"].ToString();
            clientes.ENDER = dataTable.Rows[0]["logradouro"].ToString();
            clientes.NUMERO = dataTable.Rows[0]["numero"].ToString();
            clientes.BAIRRO = dataTable.Rows[0]["bairro"].ToString();
            clientes.CIDADE = dataTable.Rows[0]["municipio"].ToString();
            clientes.UF = dataTable.Rows[0]["uf"].ToString();
            clientes.CEP = dataTable.Rows[0]["cep"].ToString();
            clientes.EMAIL = dataTable.Rows[0]["email"].ToString();
            clientes.CONTATO = dataTable.Rows[0]["contato"].ToString();
            clientes.FONE = dataTable.Rows[0]["telefone"].ToString();
            clientes.CELULAR = dataTable.Rows[0]["celular"].ToString();
            clientes.CADASTRO = dataTable.Rows[0]["data"].ToString();
            clientes.OBS = dataTable.Rows[0]["roteiro"].ToString();

            //Conexao.FecharConexao();
            return clientes;
        }

        
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

        public static string db_ExcluirDados(Clientes clientes)
        {
            try
            {
                
                string mSQL = "DELETE FROM clientes WHERE id=" + clientes.ID_CADASTRO;
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

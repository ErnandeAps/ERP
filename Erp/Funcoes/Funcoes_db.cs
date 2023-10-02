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
                    " Telefone, Celular, Data, Roteiro) Values('" + clientes.Tipo + "','" + clientes.Cnpj + "','" + clientes.Nome + "','" + clientes.Fantasia + "','" + 
                    clientes.Logradouro + "','" + clientes.Numero + "','" + clientes.Bairro + "','" + clientes.Municipio + "','" + clientes.Uf + "','" + 
                    clientes.Cep + "','" + clientes.Email + "','" + clientes.Contato + "','" + clientes.Telefone + "','" + clientes.Celular + "','" + 
                    clientes.Data + "','" + clientes.Roteiro + "')";
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
                    string mSQL = "UPDATE clientes SET tipo='" + clientes.Tipo + "', cnpj='" + clientes.Cnpj + "', Nome='" + clientes.Nome + "', Fantasia='" + clientes.Fantasia + "'," +
                    "Logradouro='" + clientes.Logradouro + "', Numero='" + clientes.Numero + "', Bairro='" + clientes.Bairro + "', Municipio='" + clientes.Municipio + "'," +
                    "Uf='" + clientes.Uf + "', Cep='" + clientes.Cep + "', Email='" + clientes.Email + "', Contato='" + clientes.Contato + "', Telefone='" + clientes.Telefone + "'," +
                    "Celular='" + clientes.Celular + "', Roteiro='" + clientes.Roteiro + "' WHERE id=" + clientes.ID +"";
                    
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
            clientes.ID = Convert.ToInt32( dataTable.Rows[0]["id"].ToString());
            clientes.Tipo = dataTable.Rows[0]["tipo"].ToString();
            clientes.Cnpj = dataTable.Rows[0]["cnpj"].ToString();
            clientes.Nome = dataTable.Rows[0]["nome"].ToString();
            clientes.Fantasia = dataTable.Rows[0]["fantasia"].ToString();
            clientes.Logradouro = dataTable.Rows[0]["logradouro"].ToString();
            clientes.Numero = dataTable.Rows[0]["numero"].ToString();
            clientes.Bairro = dataTable.Rows[0]["bairro"].ToString();
            clientes.Municipio = dataTable.Rows[0]["municipio"].ToString();
            clientes.Uf = dataTable.Rows[0]["uf"].ToString();
            clientes.Cep = dataTable.Rows[0]["cep"].ToString();
            clientes.Email = dataTable.Rows[0]["email"].ToString();
            clientes.Contato = dataTable.Rows[0]["contato"].ToString();
            clientes.Telefone = dataTable.Rows[0]["telefone"].ToString();
            clientes.Celular = dataTable.Rows[0]["celular"].ToString();
            clientes.Data = dataTable.Rows[0]["data"].ToString();
            clientes.Roteiro = dataTable.Rows[0]["roteiro"].ToString();

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
                
                string mSQL = "DELETE FROM clientes WHERE id=" + clientes.ID;
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

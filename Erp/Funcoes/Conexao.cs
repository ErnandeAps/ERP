
using FirebirdSql.Data.FirebirdClient;
using System.Configuration;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp
{
    public class ConexaoFb
    {

        public static readonly ConexaoFb instanciaFireBird = new ConexaoFb();
        private ConexaoFb() { }

        public static ConexaoFb getInstancia()
        {
            return instanciaFireBird;
        }

        public FbConnection getConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ToString();
            return new FbConnection(conn);
        }
    }
}
        

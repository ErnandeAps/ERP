
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ConfigurationManager = System.Configuration.ConfigurationManager;

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
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            
            
            string conn = configuration.GetSection("FireBirdConnectionString")?.Value;
            return new FbConnection(conn);
        }
    }
}
        

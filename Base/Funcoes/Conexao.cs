using FirebirdSql.Data.FirebirdClient;
using Microsoft.Extensions.Configuration;

namespace Base.Funcoes
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
        

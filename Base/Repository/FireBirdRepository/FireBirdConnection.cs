using FirebirdSql.Data.FirebirdClient;
using Microsoft.Extensions.Configuration;

namespace Base.Funcoes;

public class FireBirdConnection
{
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
using Base.Db;
using Base.ExternalApis;
using Base.Formularios;
using Base.Repository;
using Base.Repository.ClienteRepository;
using Base.Repository.FireBirdRepository;
using Base.Repository.FornecedorRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Refit;

namespace Base;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        ApplicationConfiguration.Initialize();
        var builder = new HostBuilder()
            .ConfigureAppConfiguration((hostContext, builder) =>
            {
                builder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            
            })
            .ConfigureServices((hostContext, services) =>
            {
                services.ConfigureDatabase(hostContext.Configuration);
                services.ConfigureExternalApis(hostContext.Configuration);
                services.AddRepositories();
                services.AddForms();
                services.AddScoped<FrmDashboard>();
            });
        var host = builder.Build();
        using var serviceScope = host.Services.CreateScope();
        {
            IServiceProvider services = serviceScope.ServiceProvider;
            var mainform = services.GetRequiredService<FrmDashboard>();
            Application.Run(mainform);
        }
    }

    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(IDatabaseRepository<>), typeof(DatabaseRepository<>));
        services.AddScoped<IClienteRepository, ClienteRepository>();
        services.AddScoped<IFornecedorRepository, FornecedorRepository>();
        services.AddScoped<IProdutoRepository, ProdutoRepository>();
        return services;
    }

    private static IServiceCollection ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<FireBirdContext>
        (x => x.UseFirebird
            (configuration.GetSection("FireBirdConnectionString")?.Value));
        return services;
    }

    private static IServiceCollection ConfigureExternalApis(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddRefitClient<ICorreiosApi>()
            .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://api.github.com"));

        services
            .AddRefitClient<IReceitaApi>()
            .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://www.receitaws.com.br/v1"));
        return services;
    }

    private static IServiceCollection AddForms(this IServiceCollection services)
    {
        services.AddScoped<FrmCadCliente>();
        services.AddScoped<FrmTelaCadastros>();
        return services;
    }
}
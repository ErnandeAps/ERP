using Erp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
                services.AddScoped<FrmDashboard>();
            });
        var host = builder.Build();
        using var serviceScope = host.Services.CreateScope();
        {
            IServiceProvider services = serviceScope.ServiceProvider;
            var mainform = services.GetRequiredService<FrmDashboard>();
            System.Windows.Forms.Application.Run(mainform);
        }
    }


}
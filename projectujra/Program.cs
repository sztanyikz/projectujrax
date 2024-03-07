using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WindowsFormsLifetime;

namespace projectujra
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            IHost app = CreateHost().Build();
            using (var servicesScope = app.Services.CreateScope())
            {
                var context = servicesScope.ServiceProvider.GetRequiredService<database>();
                context.Database.EnsureCreated();
            }
            app.Run();
        } //biztosra megy hogy van adatbazisunk
        public static IHostBuilder CreateHost()
        {
            return Host.CreateDefaultBuilder(Array.Empty<string>()).UseWindowsFormsLifetime<Form1>().ConfigureServices((hostContext, services) => //uresbol, kezdje, addig mukodjon mig van form1, source beallitasa
            {
                services.AddDbContext<database>(options =>
                {
                    options.UseSqlite("Data Source=datab.db;Cache=Shared");  //melyik sourcet hasznalja
                });
                services.AddSingleton<Model>();  //egyszerre csak egy dolgot hasznaljunk a logbol
            });
        }
    }
}
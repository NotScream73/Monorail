using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Monorail
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                Application.Run(serviceProvider.GetRequiredService<FormMapWithSetLocomotives>());
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<FormMapWithSetLocomotives>()
                    .AddLogging(option =>
                    {
                        var logger = new LoggerConfiguration().WriteTo.File("log.txt").CreateLogger();
                        option.SetMinimumLevel(LogLevel.Information);
                        option.AddSerilog(logger);
                    });
        }
    }
}
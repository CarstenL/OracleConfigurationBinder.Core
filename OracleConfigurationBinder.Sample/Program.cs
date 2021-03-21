using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OracleConfigurationBinder.Core;

namespace OracleConfigurationBinder.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .Build();

            var serviceProvider = new ServiceCollection();
            serviceProvider.AddOracleConfiguration(Configuration.GetSection("OracleConfiguration"));

            OracleSample.Sample();
        }
    }
}

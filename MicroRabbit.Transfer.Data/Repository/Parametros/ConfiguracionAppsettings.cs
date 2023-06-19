using MicroRabbit.Transfer.Domain.Interfaces.Parametros;
using Microsoft.Extensions.Configuration;


namespace MicroRabbit.Transfer.Data.Repository.Parametros
{
    public class ConfiguracionAppsettings : IConfiguracionAppsettings
    {
        private readonly IConfiguration configuration;

        public ConfiguracionAppsettings(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        //public ConfiguracionAppsettings()
        //{
        //    configuration = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json")
        //        .Build();
        //}
        public int ObtenerValorAppSetings()
        {
            string valor = configuration["Sucursal"];
            return int.Parse(valor);
        }
    }
}

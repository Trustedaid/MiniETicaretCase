using Microsoft.Extensions.Configuration;
namespace MiniETicaretAPI.Persistence;


    static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                var configurationManager = new ConfigurationManager();

                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),
                    "../../Presentation/MiniETicaretAPI.API"));
            
                configurationManager.AddJsonFile("appsettings.json");

                var connectionString = configurationManager.GetConnectionString("PostgreSQL");

                return connectionString;
            }
        }
    }

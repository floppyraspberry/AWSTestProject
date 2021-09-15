using Microsoft.Extensions.Configuration;

using System.IO;

namespace Helpers.Configuration
{
    
    public class ConfigurationRead
    { 
        public static IConfiguration Create()
        {
            var directory = Directory.GetCurrentDirectory();
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(directory)
                .AddJsonFile("Configuration/Appsettings.json", optional: true, reloadOnChange: false)
                .Build();

            return configuration;
        }
    }
}

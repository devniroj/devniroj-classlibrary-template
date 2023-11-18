using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NirojTemplate.Library.Infrastructure.IntegrationTests.Configurations
{
    public class InjectionFixture : IDisposable
    {
        private readonly IHost _host;
        public InjectionFixture()
        {
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables().Build();

            _host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, service) =>
                {

                }).Build();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IServiceProvider ServiceProvider => _host.Services;
        public IConfigurationRoot Configuration { get; }
    }
}

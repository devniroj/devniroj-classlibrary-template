using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NirojTemplate.Library.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NirojTemplate.Library.Infrastructure.IntegrationTests
{
    public class IntegrationTestWebApplicationFactory
    : WebApplicationFactory<Program>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                services.AddApplicationServices();
                services.AddInfrastructureServices();
            });
        }
    }
}

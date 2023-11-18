// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

try
{
	var configBuilder = new ConfigurationBuilder();
	configBuilder.AddJsonFile("appsettings.json");
	var configuration = configBuilder.Build();

	var host = Host.CreateDefaultBuilder(args)
		.ConfigureServices((context, services) =>
		{

		}).Build();

	Environment.Exit(0);
}
catch (Exception)
{

	throw;
}
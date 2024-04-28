// See https://aka.ms/new-console-template for more information
using ArasDocumentExport.Core.Excel;
using ArasDocumentExport.Core.Model;
using Autofac.Extensions.DependencyInjection;
using Autofac;
using Microsoft.Extensions.Hosting;
using ArasDocumentExport.Models;
using Microsoft.Extensions.DependencyInjection;
using ArasDocumentExport;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using ArasDocumentExport.Settings;

IHost host = Host.CreateDefaultBuilder(args)
    .UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureAppConfiguration((hostingContext, config) =>
    {
        config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: false);
    })
    .ConfigureContainer<ContainerBuilder>((hostContext, builder) =>
    {
        builder.RegisterModule(new ServiceModule(hostContext.Configuration));
    })
    .ConfigureServices((hostContext, services) =>
    {
        DbSettings? dbSettings = hostContext.Configuration.GetSection("DbSettings").Get<DbSettings>(c => c.BindNonPublicProperties = true);
        if (dbSettings == null)
        {
            throw new InvalidDataException("Cannot read DbSettings");
        }
        services.AddDbContext<ArasContext>(opt => opt.UseSqlServer(dbSettings.ConnectionString));
    })
    .Build();

host.Services.GetRequiredService<Application>().Start();

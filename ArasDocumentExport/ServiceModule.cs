using ArasDocumentExport.Settings;
using Autofac;
using Microsoft.Extensions.Configuration;

namespace ArasDocumentExport
{
    internal class ServiceModule : Module
    {
        IConfiguration Configuration { get; set; }

        /// <summary>
        /// 為了要取得appsettings而建立的constructor
        /// </summary>
        /// <param name="configuration"></param>
        public ServiceModule(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            DbSettings? dbSettings = Configuration.GetSection("DbSettings").Get<DbSettings>(c => c.BindNonPublicProperties = true);

            if (dbSettings == null)
            {
                throw new InvalidDataException("Cannot read DbSettings");
            }

            builder.Register(c => dbSettings).SingleInstance();
            builder.RegisterType<Application>().InstancePerLifetimeScope();
        }
    }
}

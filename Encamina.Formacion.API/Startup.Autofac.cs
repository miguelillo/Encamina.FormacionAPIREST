namespace Encamina.Formacion.API
{
    using Autofac;
    using Encamina.Formacion.API.Data;
    using Encamina.Formacion.API.Domain;
    using Encamina.Formacion.API.Repository;
    using Microsoft.Extensions.Logging;

    public partial class Startup
    {
        public ILifetimeScope AutoFacContainer { get; private set; }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            AddConfigureAutofac(builder);
        }

        private void AddConfigureAutofac(ContainerBuilder builder)
        {
            builder.RegisterType<AvengerFilmRepository>().As<IAvengerFilmRepository>();
            builder.RegisterType<AvengerRepository>().As<IAvengerRepository>();
            builder.RegisterType<FilmRepository>().As<IFilmRepository>();

            builder.RegisterType<AvengerDomain>().As<IAvengerDomain>();
            builder.RegisterType<FilmDomain>().As<IFilmDomain>();
            builder.RegisterType<AvengerDbContext>().AsSelf();

            builder.Register(c =>
            {
                ILoggerFactory loggerFactory = new LoggerFactory();
                return loggerFactory.CreateLogger("logger");
            }).As<ILogger>();
        }
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pedalea.Infraestructura.Adaptadores.Repositorios;
using Pedalea.Infraestructura.Puertos;
using System.Data;
using System.Data.SqlClient;

namespace Pedalea.Infraestructura.Extensiones
{
    public static class PersistenciaDatos
    {
        public static IServiceCollection AgregarPersistenciaDatos(this IServiceCollection svc, IConfiguration config)
        {
            svc.AddTransient<IDbConnection>(_ => new SqlConnection(config.GetConnectionString("PedaleaDb")));
            svc.AddTransient(typeof(ILectorArchivosSql), typeof(LectorArchivosSql));

            var repositories = AppDomain.CurrentDomain.GetAssemblies().Where(assembly =>
            {
                return assembly.FullName is not null && assembly.FullName.Contains("Pedalea.Infraestructura", StringComparison.InvariantCulture);
            }).
            SelectMany(repo => repo.GetTypes())
            .Where(properties => properties.CustomAttributes.Any(customProperty => customProperty.AttributeType == typeof(RepositorioAttribute)));

            foreach (Type repo in repositories)
            {
                svc.AddTransient(repo.GetInterfaces().First(), repo);
            }

            return svc;
        }


    }
}

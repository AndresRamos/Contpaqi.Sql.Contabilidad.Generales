using System.Data.SqlClient;

namespace Contpaqi.Sql.Contabilidad.Generales.Factories
{
    public static class ContabilidadGeneralesDbContextFactory
    {
        public const string NombreBaseDatos = "GeneralesSQL";

        public static ContabilidadGeneralesDbContext CreateInstance(string contpaqiConnectionString)
        {
            var connectionStringBuilder = new SqlConnectionStringBuilder(contpaqiConnectionString)
            {
                InitialCatalog = NombreBaseDatos
            };

            return new ContabilidadGeneralesDbContext(new SqlConnection(connectionStringBuilder.ToString()), true);
        }
    }
}
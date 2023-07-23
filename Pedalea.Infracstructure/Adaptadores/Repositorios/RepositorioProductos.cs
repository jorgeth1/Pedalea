using System.Data;
using Pedalea.Dominio.Entidades;
using Pedalea.Dominio.Puertos.Repositorios;
using Pedalea.Infraestructura.Puertos;
using Dapper;


namespace Pedalea.Infraestructura.Adaptadores.Repositorios
{
    [Repositorio]
    public class RepositorioProductos : IRepositorioProductos
    {
        private readonly ILectorArchivosSql _readerQueryFile;
        private readonly IDbConnection _dbConnection;
        public RepositorioProductos(ILectorArchivosSql readerQueryFile, IDbConnection dbConnection)
        {
            _readerQueryFile = readerQueryFile;
            _dbConnection = dbConnection;
        }
        public async Task<IEnumerable<Producto>> ObtenerTodosConInventario(Func<Producto, bool>? filter = null)
        {
            string query = await _readerQueryFile.GetQueryFromFile("Adaptadores/Repositorios/Consultas/ObtenerProductosInventario.sql");
            _dbConnection.Open();
            var productos = (await _dbConnection.QueryAsync<Producto>(query));

            return filter is not null ? productos.Where(filter) : productos;
        }
    }
}

using Pedalea.Dominio.Entidades;

namespace Pedalea.Dominio.Puertos.Repositorios
{
    public interface IRepositorioProductos
    {
        Task<IEnumerable<Producto>> ObtenerTodosConInventario(Func<Producto, bool>? filter = null);
    }
}

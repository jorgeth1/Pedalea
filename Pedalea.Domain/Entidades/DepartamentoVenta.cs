using Pedalea.Dominio.Entidades.Base;

namespace Pedalea.Dominio.Entidades
{
    public class DepartamentoVenta : BaseEntity<Guid>
    {
        public string Nombre { get; set; } = null!;
        public List<Producto> Productos { get; set; } = null!;
    }

}

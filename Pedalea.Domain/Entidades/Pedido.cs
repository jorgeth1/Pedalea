using Pedalea.Dominio.Entidades.Base;

namespace Pedalea.Dominio.Entidades
{
    public class Pedido : BaseEntity<Guid>
    {
        public DateTime Fecha { get; set; }
        public decimal PrecioTotal { get; set; }

        public Guid ClienteId { get; set; }
        public List<DetallePedido> DetallesPedido { get; set; } = null!;

    }

}

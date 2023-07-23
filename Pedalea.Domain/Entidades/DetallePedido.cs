using Pedalea.Dominio.Entidades.Base;

namespace Pedalea.Dominio.Entidades
{
    public class DetallePedido
    {
        public Guid PedidoId { get; set; }
        public Guid ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }

}

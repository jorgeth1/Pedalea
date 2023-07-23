using Pedalea.Dominio.Entidades.Base;

namespace Pedalea.Dominio.Entidades
{
    public class Cliente : BaseEntity<Guid>
    {
        public string Nombre { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int PedidosRegistrados { get; set; }
        public List<Pedido> Pedidos { get; set; } = null!;
        public List<PlanSepare> ListadoPlanSepare { get; set; } = null!;
    }

}

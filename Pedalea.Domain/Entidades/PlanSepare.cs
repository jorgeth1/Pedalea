using Pedalea.Dominio.Entidades.Base;

namespace Pedalea.Dominio.Entidades
{
    public class PlanSepare : BaseEntity<Guid>
    {
        public Guid ClienteId { get; set; }
        public decimal Valor { get; set; }
    }

}

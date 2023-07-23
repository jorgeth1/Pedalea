using Pedalea.Dominio.Entidades.Base;

namespace Pedalea.Dominio.Entidades
{
    public class MontoMinimoPlanSepare : BaseEntity<Guid>
    {
        public decimal PorcentajePromocion { get; set; }
        public decimal MontoParametrizado { get; set; }
    }

}

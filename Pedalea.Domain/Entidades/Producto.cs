using Pedalea.Dominio.Entidades.Base;

namespace Pedalea.Dominio.Entidades
{
    public class Producto : BaseEntity<Guid>
    {
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Cantidad { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public decimal Precio { get; set; }
        public bool IsOutlet { get; set; }

        public Guid DepartamentoVentaId { get; set; }

    }

}

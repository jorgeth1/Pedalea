namespace Pedalea.Aplicacion.Productos.Dtos
{
    public class ProductoDto
    {
        public ProductoDto(Guid id, string nombre, Guid idDepartamentoVenta)
        {
            Nombre = nombre;
            IdDepartamentoVenta = idDepartamentoVenta;
            Id = id;
        }

        public Guid IdDepartamentoVenta { get; }
        public Guid Id { get; }
        public string Nombre { get; }
    }
}

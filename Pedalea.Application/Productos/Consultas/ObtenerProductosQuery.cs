using Pedalea.Aplicacion.Productos.Dtos;
using MediatR;

namespace Pedalea.Aplicacion.Productos.Consultas
{
    public record ObtenerProductosQuery() : IRequest<IEnumerable<ProductoDto>>;
}

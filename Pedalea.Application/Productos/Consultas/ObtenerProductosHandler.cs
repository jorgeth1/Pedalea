namespace Pedalea.Aplicacion.Productos.Consultas
{
    using AutoMapper;
    using MediatR;
    using Pedalea.Aplicacion.Productos.Dtos;
    using Pedalea.Dominio.Puertos.Repositorios;
    using System.Threading;
    using System.Threading.Tasks;

    public class ObtenerProductosHandler : IRequestHandler<ObtenerProductosQuery, IEnumerable<ProductoDto>>
    {
        private readonly IMapper _mapper;
        private readonly IRepositorioProductos _repositorioProductos;
        public ObtenerProductosHandler(IMapper mapper, IRepositorioProductos repositorioProductos)
        {
            _mapper = mapper;
            _repositorioProductos = repositorioProductos;
        }
        public async Task<IEnumerable<ProductoDto>> Handle(ObtenerProductosQuery request, CancellationToken cancellationToken)
        {
            var response = await _repositorioProductos.ObtenerTodosConInventario();
            return _mapper.Map<IEnumerable<ProductoDto>>(response);
        }
    }
}

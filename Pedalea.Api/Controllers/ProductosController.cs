
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Pedalea.Aplicacion.Productos.Dtos;
using Pedalea.Aplicacion.Productos.Consultas;

namespace Pedalea.Api.Controllers
{
    [Route("api/productos")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductoDto>> ObtenerTodosLosProductosInventariados()
            => await _mediator.Send(new ObtenerProductosQuery());
    }
}

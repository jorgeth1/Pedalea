using AutoMapper;

namespace Pedalea.Aplicacion.Productos.Dtos
{
    public class ProductosProfile : Profile
    {
        public ProductosProfile()
        {
            CreateMap<Pedalea.Dominio.Entidades.Producto, ProductoDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
            .ForMember(dest => dest.IdDepartamentoVenta, opt => opt.MapFrom(src => src.DepartamentoVentaId));

        }
    }
}

using AutoMapper;
using Facturacion.DTOs;
using Facturacion.Models;

namespace Facturacion.Mapping
{
    public class PerfilMappings : Profile
    {
        public PerfilMappings() 
        {
            CreateMap<Cliente, EntidadRegistroCliente>();
            CreateMap<EntidadRegistroCliente, Cliente>();
            CreateMap<Factura, EntidadRegistroFactura>();
            CreateMap<EntidadRegistroFactura, Factura>();
            CreateMap<Usuario, EntidadRegistroUsuario>();
            CreateMap<EntidadRegistroUsuario, Usuario>();
        }
    }
}

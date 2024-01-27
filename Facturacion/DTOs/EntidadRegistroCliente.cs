using Facturacion.Models;

namespace Facturacion.DTOs
{
    public class EntidadRegistroCliente
    {
        public int IdCliente { get; set; }

        public string Nombre { get; set; }

        public DateOnly FechaCreacion { get; set; }

        public DateOnly FechaModificacion { get; set; }
    }
}

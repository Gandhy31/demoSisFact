namespace Facturacion.DTOs
{
    public class EntidadRegistroFactura
    {
        public int IdFactura { get; set; }

        public string Nombre { get; set; }

        public DateOnly FechaCreacion { get; set; }

        public DateOnly FechaModificacion { get; set; }

        public int IdUsuario { get; set; }

        public int IdCliente { get; set; }
    }
}

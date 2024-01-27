namespace Facturacion.DTOs
{
    public class EntidadRegistroUsuario
    {
        public int IdUsuario { get; set; }

        public string Nombre { get; set; }

        public DateOnly FechaCreacion { get; set; }

        public DateOnly FechaModificacion { get; set; }
    }
}

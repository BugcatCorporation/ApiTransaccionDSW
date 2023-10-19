using System;
using System.Collections.Generic;

namespace ApiTransaccion.Models
{
    public class Venta
    {
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }
        public int UsuarioId { get; set; }
        public string? Nombre { get; set; }
        public decimal Total { get; set; }
        public ICollection<DetalleVenta>? DetalleVentas { get; set; }
    }
}
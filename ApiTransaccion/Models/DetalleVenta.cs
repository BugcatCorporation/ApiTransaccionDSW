namespace ApiTransaccion.Models
{
    public class DetalleVenta
    {
        public int DetalleVentaId { get; set; }        
        public int ProductoId { get; set; }
        public string? Nombre { get;  set; }
        public decimal Precio { get;  set; }
        public int Cantidad { get;  set;}
        public decimal Subtotal { get; set;}
        public int? VentaId { get; set; }
        public Venta? Ventas  { get; set; }
    }
}

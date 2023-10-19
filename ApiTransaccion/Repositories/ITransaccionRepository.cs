using ApiTransaccion.Models;

namespace ApiTransaccion.Repositories
{
    public interface ITransaccionRepository
    {
        public Task<bool> GenerarVenta(Venta venta); 
    }
}

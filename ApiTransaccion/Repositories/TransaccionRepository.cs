using ApiTransaccion.DbContexts;
using ApiTransaccion.Models;

namespace ApiTransaccion.Repositories
{
    public class TransaccionRepository : ITransaccionRepository
    {
        private BugcatDBContext dBContext;
        public TransaccionRepository(BugcatDBContext dBContext)
        { 
            this.dBContext = dBContext;
        }

        public async Task<bool> GenerarVenta(Venta venta)
        {
            try
            {
                dBContext.Ventas.Add(venta);
                await dBContext.SaveChangesAsync();
                return true;
            }
            catch 
            { 
                return false;
            }
        }
    }
}

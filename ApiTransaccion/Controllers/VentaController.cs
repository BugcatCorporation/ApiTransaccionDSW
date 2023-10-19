
using ApiTransaccion.Models;
using ApiTransaccion.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiTransaccion.Controllers
{
    [ApiController]
    [Route ("api/v1/[controller]")]
    public class VentaController : ControllerBase
    {
        public ITransaccionRepository tr { get; set; }
        public VentaController(ITransaccionRepository tr) 
        {
            this.tr = tr;
        }
        [HttpPost]
        [Route("/GenerarVenta")]
        public async Task<bool> GenerarVenta(Venta venta)
        {
            return await tr.GenerarVenta(venta);
        }
    }
}

using System;
using System.Collections.Generic;
using ApiTransaccion.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiTransaccion.DbContexts
{
    public partial class BugcatDBContext : DbContext
    {
        public BugcatDBContext()
        {
        }

        public BugcatDBContext(DbContextOptions<BugcatDBContext> options) : base(options)
        {
        }

        public DbSet<DetalleVenta> DetalleVentas { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        

    }

}

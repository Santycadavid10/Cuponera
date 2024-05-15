using Microsoft.EntityFrameworkCore;
using Cupones.Models;
using Clientes.Models;
using Productos.Models;

namespace LuegoPago.Data;
public class LuegoPagoContext : DbContext
{
    public LuegoPagoContext(DbContextOptions<LuegoPagoContext> options) : base(options)
    {
    }
    public DbSet<Cupon> Cupones { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Producto> Productos { get; set; }
}
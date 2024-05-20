using Microsoft.EntityFrameworkCore;
using Cupones.Models;
using Clientes.Models;
using Tiendas.Models;

namespace LUEGOPAGO.Data;
public class LuegoPagoContext : DbContext
{
    public LuegoPagoContext(DbContextOptions<LuegoPagoContext> options) : base(options)
    {
    }
    public DbSet<Cupon> Cupones { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Tienda> Tiendas { get; set; }
}
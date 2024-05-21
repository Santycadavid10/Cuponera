using Cupones.Models;
using Tiendas.Models;

namespace CrearCupones.Models
{
    public class CrearCupon
    {
        public Cupon? Cupon { get; set; }
        public IEnumerable<Tienda>? Tiendas { get; set; }
    }
}
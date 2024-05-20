using Cupones.Models;
using Tiendas.Models;
using System.Collections.Generic;

namespace Vistascupones.Models
{
    public class Vistascupon
    {
        public Cupon? Cupon { get; set; }
        public IEnumerable<Tienda>? Tiendas { get; set; }
    }
}
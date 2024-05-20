
using System.ComponentModel.DataAnnotations.Schema;

namespace Cupones.Models;

public class Cupon
{
    public int Id { get; set; }
    public string? NombreCupon { get; set; }
    public decimal ValorCupon { get; set; }
    public string? TiendasCupon { get; set; }

    public string? TipoCupon { get; set; }
    public DateTime FechaInicioCupon { get; set; }
    public DateTime FechaFinalCupon { get; set; }
    public string? DescripcionCupon { get; set; }
    public int CantidadCupon { get; set; }
    public int AcumulableCupon { get; set; }
    public decimal ValorMinimoCupon { get; set; }
    public decimal ValorMaximoCupon { get; set; }
    public string? ImagenCupon { get; set; } // Ruta de la imagen en wwwroot
    [NotMapped]
    public IFormFile? ImagenReal { get; set; } // Archivo de imagen

        
}

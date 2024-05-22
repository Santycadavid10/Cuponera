
using System.ComponentModel.DataAnnotations.Schema;

namespace Cupones.Models;

public class Cupon
{
    public int Id { get; set; }
    public string? NombreCupon { get; set; }
    public double ValorCupon { get; set; }
    public string? TiendasCupon { get; set; }
    public string? EstadoCupon { get; set; }
    public string? TipoCupon { get; set; }
    public DateTime FechaInicioCupon { get; set; }
    public DateTime FechaFinalCupon { get; set; }
    public string? DescripcionCupon { get; set; }
    public int CantidadCupon { get; set; }
    public int AcumulableCupon { get; set; }
    public double ValorMinimoCupon { get; set; }
    public double ValorMaximoCupon { get; set; }
    public string? ImagenCupon { get; set; } // Ruta de la imagen en wwwroot
    [NotMapped]
    public IFormFile? ImagenReal { get; set; } // Archivo de imagen

        
}

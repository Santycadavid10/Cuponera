namespace Cupones.Models;
public class Cupon
{
    public int Id { get; set; }
    public string?  Creador { get; set; }
    public string?  Nombre { get; set; }
    public string?  Imagen { get; set; }
    public string?  Descripcion { get; set; }
    public int ValorCupon { get; set; }
    public int  Cantidad { get; set; }
    public int 	CantidadAcumulable { get; set; }
    public DateTime	FechaInicio { get; set; }
    public DateTime	FechaFinal { get; set; }
    public int 	ValorMinimo { get; set; }
    public int 	ValorMaximo { get; set; }

}
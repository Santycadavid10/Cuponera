namespace Productos.Models;
public class Producto
{
    public int Id { get; set; }
    public string?  Nombre { get; set; }
    public string?  Codigo { get; set; }
    public string?  Categoria { get; set; }
    public int 	Precio { get; set; }
    public int 	Vendidos { get; set; }
    public int 	Disponibles { get; set; }
    public string? Imagen { get; set; }
}
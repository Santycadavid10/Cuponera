namespace Clientes.Models;
public class Cliente
{
    public int Id { get; set; }
    public string?  Contraseña { get; set; }
    public string?  Nombre { get; set; }
    public string?  Documento { get; set; }
    public string?  Celular { get; set; }
    public string? Correo { get; set; }
    public string?  Departamento { get; set; }
    public string? 	Ciudad { get; set; }
    public string?	Direccion { get; set; }
    public int 	Deuda { get; set; }
    public string? 	Foto { get; set; }
}
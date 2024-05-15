using LuegoPago.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Clientes.Models;

namespace Clientes.Controllers;
public class ClientesController : Controller
{
  public readonly LuegoPagoContext _Context;
  public ClientesController(LuegoPagoContext context)
  {
    _Context = context;
  }

  public async Task<IActionResult> Client()
  {
    return View(await _Context.Clientes.ToListAsync());
  }
}
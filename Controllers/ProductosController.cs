using LuegoPago.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Productos.Models;

namespace Productos.Controllers;
public class ProductosController : Controller
{
  public readonly LuegoPagoContext _Context;
  public ProductosController(LuegoPagoContext context)
  {
    _Context = context;
  }

  public async Task<IActionResult> Productos()
  {
    return View(await _Context.Productos.ToListAsync());
  }
}
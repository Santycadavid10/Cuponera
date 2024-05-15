using LuegoPago.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cupones.Models;

namespace Cupones.Controllers;
public class CuponesController : Controller
{
  public readonly LuegoPagoContext _Context;
  public CuponesController(LuegoPagoContext context)
  {
    _Context = context;
  }

  public async Task<IActionResult> Index()
  {
    return View(await _Context.Cupones.ToListAsync());
  }
}
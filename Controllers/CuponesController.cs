using LUEGOPAGO.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrearCupones.Models;
using Cupones.Models; 


namespace Cupones.Controllers
{
    public class CuponesController : Controller
    {

        private readonly IWebHostEnvironment _hostEnvironment;

        private readonly LuegoPagoContext _context;

        public CuponesController(IWebHostEnvironment hostEnvironment, LuegoPagoContext context)
        {
           _hostEnvironment = hostEnvironment;
            _context = context;
        }
        /*----------------------Listar Cupones */

        public async Task<IActionResult> VerCupones()
        {
            return View(await _context.Cupones.ToListAsync());
        }




/*----------------------Crear cupon-------------------------------------------------------------------------------*/
public async Task<IActionResult> CrearCupones()
        {
            var viewModel = new CrearCupon
            {
                Tiendas = await _context.Tiendas.ToListAsync()
            };
            return View(viewModel);
        }

       
[HttpPost]
        public async Task<IActionResult> Create([Bind("NombreCupon,ValorCupon,TiendasCupon,TipoCupon,FechaInicioCupon,FechaFinalCupon,DescripcionCupon,CantidadCupon,AcumulableCupon,ValorMinimoCupon,ValorMaximoCupon,ImagenReal")] Cupon newcupon)
        {
            if (ModelState.IsValid)
            {
                // Guardar la imagen en wwwroot/images
                if (newcupon.ImagenReal != null)
                {
                    string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "images");
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + newcupon.ImagenReal.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await newcupon.ImagenReal.CopyToAsync(fileStream);
                    }

                    // Guardar la ruta de la imagen en el modelo
                    newcupon.ImagenCupon = "/images/" + uniqueFileName;
                
              //////////////////////////////////////////////////////////////////////////////////////////
               
                  _context.Cupones.Add(newcupon);
                await _context.SaveChangesAsync();
                return RedirectToAction("VerCupones");
                }
                
            }
            // Error en el modelo, redireccionar con mensaje de error
            ViewBag.Message = "Error al guardar el cupón.";
            return View(newcupon);
        }

        
    }
}


using ManejoPresupuestos.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManejoPresupuestos.Controllers
{
    public class TiposCuentasController : Controller
    {
        public IActionResult Crear() { 
        
           return View();
        }

        [HttpPost]
        public IActionResult Crear(TipoCUenta cUenta)
        {
            if (!ModelState.IsValid)
            {
                return View(cUenta);
            }

            return View();
            
        }
    }
}

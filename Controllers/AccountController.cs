using Microsoft.AspNetCore.Mvc;

namespace ProgramacionAvanzadaWebProyecto.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RecuperarCuenta()
        {
            return View();
        }
    }
}

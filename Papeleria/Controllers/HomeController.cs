using LogicaAplicacion.CasosUsoLogin.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.Models;
using System.Diagnostics;

namespace Papeleria.Controllers
{
    public class HomeController : Controller
    {
        #region Properties
        private readonly ILogger<HomeController> _logger;

        public ICasoUsoLogin CULoguearUsuario { get; private set; }
        #endregion

        #region Constructors
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        #endregion

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string contrasenia)
        {
            Usuario? usuarioLogueado = CULoguearUsuario.Loguear(email, contrasenia);

            if (usuarioLogueado != null)
                HttpContext.Session.SetString("email", email);

            return RedirectToAction("Index", "Usuarios");
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Remove("email");
            return RedirectToAction("Login");
        }

        #region Unused
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion
    }
}
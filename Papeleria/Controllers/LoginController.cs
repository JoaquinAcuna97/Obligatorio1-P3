using Microsoft.AspNetCore.Mvc;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesAccesoDatos;
using Microsoft.AspNetCore.Http;
using Papeleria.Web.Controllers;

namespace Papeleria.Controllers
{
    public class LoginController : Controller
    {
        public IRepositorioUsuario repositorioUsuario { get; set; }
        public LoginController(IRepositorioUsuario repositorioUsuario)
        {
            this.repositorioUsuario = repositorioUsuario;
        }


        [HttpGet]
        public ActionResult Login()
        {
            string strid = HttpContext.Session.GetString("id");
            if (!string.IsNullOrEmpty(strid))
            {
                int id = Int32.Parse(strid);
                Usuario? usuario = this.repositorioUsuario.FindByID(id);
                if (usuario == null)
                {
                    return RedirectToAction("Index", "Usuario");
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string contrasena)
        {
            Usuario? usuarioLogueado = this.repositorioUsuario.FindByEmailPassword(email, contrasena);
            if (usuarioLogueado != null)
             {
                    HttpContext.Session.SetString("id", usuarioLogueado.Id.ToString());
                    return RedirectToAction("Index", "Usuario");
            }
            

            ViewBag.Mensaje = "Usuario o contraseña incorrectos";
            return View();
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

    }
}

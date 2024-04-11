using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesAccesoDatos;
using Papeleria.LogicaNegocio.ValueObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Papeleria.Web.Controllers
{
    public class UsuarioController : Controller
    {
        public IRepositorioUsuario repositorioUsuario { get; set; }
        public UsuarioController(IRepositorioUsuario repositorioUsuario) 
        {
            this.repositorioUsuario = repositorioUsuario;
        }
        // GET: UsuarioController
        public ActionResult Index()
        {
            return View(repositorioUsuario.FindAll());
        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuario usuario, string nombre, string apellido, string email, string contrasena, string contrasenaEncriptada)
        {
                NombreCompleto nombreUsuario = new NombreCompleto(nombre, apellido);
                usuario.NombreCompleto = nombreUsuario;
                usuario.Email = email;
                usuario.Contrasena = contrasena;
                usuario.ContrasenaEncriptada = contrasenaEncriptada;
                repositorioUsuario.Add(usuario);
                return RedirectToAction(nameof(Index));
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(repositorioUsuario.FindByID(id));
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, string nombre, string apellido, string contrasena, string contrasenaEncriptada)
        {
            Usuario usuario = repositorioUsuario.FindByID(id);

            
                NombreCompleto nombreUsuario = new NombreCompleto(nombre, apellido);
                usuario.NombreCompleto = nombreUsuario;
                usuario.Contrasena = contrasena;
                usuario.ContrasenaEncriptada = contrasenaEncriptada;
                repositorioUsuario.Update(usuario);
                return RedirectToAction(nameof(Index));

        }

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View(repositorioUsuario.FindByID(id));
        }

        // POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
                repositorioUsuario.Remove(id);
                return RedirectToAction(nameof(Index));
        }
    }
}

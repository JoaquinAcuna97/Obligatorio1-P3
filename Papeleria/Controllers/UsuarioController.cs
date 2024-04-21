using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.ValueObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Papeleria.AccesoDatos.Interfaces;

namespace Papeleria.Web.Controllers
{
    public class UsuarioController(IRepositorioUsuario repositorioUsuario) : Controller
    {
        public IRepositorioUsuario RepositorioUsuario { get; set; } = repositorioUsuario;

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
        public ActionResult Create(Usuario usuario, String nombre, String apellido, String email)
        {
            try
            {
                NombreCompleto nombreUsuario = new NombreCompleto(nombre, apellido);
                usuario.NombreCompleto = nombreUsuario;
                repositorioUsuario.Add(usuario);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View(RepositorioUsuario.FindById(id));
        }

        // POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                repositorioUsuario.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

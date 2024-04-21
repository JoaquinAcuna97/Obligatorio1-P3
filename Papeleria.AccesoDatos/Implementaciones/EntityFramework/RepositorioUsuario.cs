using Papeleria.AccesoDatos.Interfaces;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Excepciones.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.Implementaciones.EntityFramework
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private PapeleriaContext _context;

        public RepositorioUsuario()
        {
            _context = new PapeleriaContext();
        }

        #region CRUD 
        public void Add(Usuario usuarioNuevo)
        {
            try
            {
                usuarioNuevo.EsValido();
                _context.Usuarios.Add(usuarioNuevo);
                _context.SaveChanges();
            }
            catch (UsuarioNoValidoException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            Usuario aBorrar = FindById(id);
            _context.Usuarios.Remove(aBorrar);
            _context.SaveChanges();
        }

        public IEnumerable<Usuario> FindAll()
        {
            return _context.Usuarios;
        }

        public Usuario FindById(int id)
        {
            if (_context.Usuarios.Count() < 1)
            {
                throw new Exception("La tabla de Usuarios esta vacia");
            }

#pragma warning disable CS8603 // Possible null reference return checked before
            return _context.Usuarios.FirstOrDefault(usuario => usuario.Id == id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public void Update(Usuario usuarioEditado)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

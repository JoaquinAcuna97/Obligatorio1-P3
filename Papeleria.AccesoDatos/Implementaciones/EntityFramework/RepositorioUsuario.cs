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
        private readonly PapeleriaContext _papeleriaContext;

        public RepositorioUsuario()
        {
            _papeleriaContext = new PapeleriaContext();
        }

        #region CRUD Operations
        public void Add(Usuario usuarioNuevo)
        {
            try
            {
                usuarioNuevo.EsValido();
                _papeleriaContext.Usuarios.Add(usuarioNuevo);
                _papeleriaContext.SaveChanges();
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
            _papeleriaContext.Usuarios.Remove(aBorrar);
            _papeleriaContext.SaveChanges();
        }

        public IEnumerable<Usuario> FindAll()
        {
            return _papeleriaContext.Usuarios;
        }

        public Usuario FindById(int id)
        {
            if (_papeleriaContext.Usuarios.Count() < 1)
            {
                throw new Exception("La tabla de Usuarios esta vacia");
            }

#pragma warning disable CS8603 // Possible null reference return checked before
            return _papeleriaContext.Usuarios.FirstOrDefault(usuario => usuario.Id == id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public void Update(Usuario usuarioEditado)
        {
            try
            {
                usuarioEditado.EsValido();
                _papeleriaContext.Usuarios.Update(usuarioEditado);
                _papeleriaContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}

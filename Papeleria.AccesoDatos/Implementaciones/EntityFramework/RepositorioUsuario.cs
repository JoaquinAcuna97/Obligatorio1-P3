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
            try
            {
                Usuario aBorrar = FindById(id);
                _papeleriaContext.Usuarios.Remove(aBorrar);
                _papeleriaContext.SaveChanges();
            }
            catch (Exception)
            {
                //TODO: Usuario no encontrado exception
                throw;
            }
        }

        public IEnumerable<Usuario> FindAll()
        {
            return _papeleriaContext.Usuarios;
        }

        public Usuario FindById(int id)
        {
            if (!_papeleriaContext.Usuarios.Any())
            {
                //Excepcion personalizada, tabla vacia
                throw new Exception("La tabla de Usuarios esta vacia");
            }

            Usuario? usuarioEncontrado = _papeleriaContext.Usuarios.FirstOrDefault(usuario => usuario.Id == id);
            //TODO: Expection personalizada, no se encontro el usuario
            return usuarioEncontrado ?? throw new Exception($"No se pudo encontrar el usuario de ID: {id}");
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

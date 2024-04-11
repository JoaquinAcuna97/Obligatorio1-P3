using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Excepciones.Usuario;
using Papeleria.LogicaNegocio.InterfacesAccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.EntityFramework.Repositorios
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private PapeleriaContext _context;

        public RepositorioUsuario()
        {
            this._context = new PapeleriaContext();
        }

        public bool Add(Usuario aAgregar)
        {
            try
            {
                aAgregar.EsValido();
                _context.usuarios.Add(aAgregar);
                _context.SaveChanges();
                return true;
            }
            catch (UsuarioNoValidoException exception)
            {
                throw exception;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Usuario> FindAll()
        {
            return _context.usuarios;
        }

        public Usuario FindByID(int id)
        {
            return _context.usuarios.Where(usuario => usuario.Id == id).FirstOrDefault();
        }
        public Usuario FindByEmailPassword(string email, string password)
        {
            Usuario usuario = _context.usuarios.Where(usuario => usuario.Email == email && usuario.Contrasena == password).FirstOrDefault();
            if (usuario == null)
            {
                //TODO: encriptar contrasena y buscar por contrasena encriptada
                throw new FileNotFoundException();
            }
            return usuario;
        }
        public bool Remove(int id)
        {
            Usuario aBorrar = new Usuario();
            aBorrar.Id = id;
            _context.usuarios.Remove(aBorrar);
            _context.SaveChanges(); 
            return true;
        }

        public bool Update(Usuario aActualizar)
        {
            _context.Update(aActualizar);
            _context.SaveChanges();
            return true;
        }
    }
}

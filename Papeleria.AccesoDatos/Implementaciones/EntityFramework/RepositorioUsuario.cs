﻿using Papeleria.AccesoDatos.Interfaces;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Excepciones.Generales;
using Papeleria.LogicaNegocio.Excepciones.Pedidos;
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
                Usuario.EsValido(usuarioNuevo);
                _papeleriaContext.Usuarios.Add(usuarioNuevo);
                _papeleriaContext.SaveChanges();
            }
            catch (UsuarioNuloException)
            {
                throw;
            }
            catch (UsuarioNoValidoException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error desconocido: {ex.Message} (Trace: {ex.StackTrace})");
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
            catch (UsuarioNoEncontradoException)
            {
                throw;
            }catch (Exception)
            {
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
                throw new DataBaseSetException("La tabla de Usuarios esta vacia");
            }

            Usuario? usuarioEncontrado = _papeleriaContext.Usuarios.FirstOrDefault(usuario => usuario.Id == id);
            return usuarioEncontrado ?? throw new UsuarioNoEncontradoException($"No se pudo encontrar el usuario de ID: {id}");
        }

        public void Update(Usuario usuarioEditado)
        {
            try
            {
                Usuario.EsValido(usuarioEditado);
                _papeleriaContext.Usuarios.Update(usuarioEditado);
                _papeleriaContext.SaveChanges();
            }
            catch (UsuarioNuloException)
            {
                throw;
            }
            catch (UsuarioNoValidoException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error desconocido: {ex.Message} (Trace: {ex.StackTrace})");
            }
        }
        #endregion

        #region Custom operation
        public Usuario FindByEmail(string email)
        {
            if (!_papeleriaContext.Usuarios.Any())
            {
                throw new DataBaseSetException("La tabla de Usuarios esta vacia");
            }

            Usuario? usuarioEncontrado =  _papeleriaContext.Usuarios.FirstOrDefault(usuario => usuario.Email.DireccionEmail == email);
            return usuarioEncontrado ?? throw new UsuarioNoEncontradoException($"No se pudo encontrar el usuario de email: {email}");
        }
        #endregion
    }
}

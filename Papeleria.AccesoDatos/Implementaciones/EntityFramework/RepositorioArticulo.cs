using Papeleria.AccesoDatos.Interfaces;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Excepciones.Articulos;
using Papeleria.LogicaNegocio.Excepciones.Clientes;
using Papeleria.LogicaNegocio.Excepciones.Generales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.Implementaciones.EntityFramework
{
    public class RepositorioArticulo : IRepositorioArticulo
    {
        private readonly PapeleriaContext _papeleriaContext;

        public RepositorioArticulo()
        {
            _papeleriaContext = new PapeleriaContext();
        }

        #region CRUD Operations
        public void Add(Articulo articuloNuevo)
        {
            try
            {
                articuloNuevo.EsValido();
                _papeleriaContext.Articulos.Add(articuloNuevo);
                _papeleriaContext.SaveChanges();
            }
            catch (ArticuloNoEncontradoException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error desconocido: {ex.Message} (Trace: {ex.StackTrace})");
            }
        }

        public IEnumerable<Articulo> FindAll()
        {
            if (!_papeleriaContext.Articulos.Any())
            {
                throw new DataBaseSetException("La tabla Articulos esta vacia");
            }

            return _papeleriaContext.Articulos;
        }

        public Articulo FindById(int id)
        {
            if (!_papeleriaContext.Articulos.Any())
            {
                throw new DataBaseSetException("La tabla Articulos esta vacia");
            }

            try
            {
                Articulo? articuloEncontrado = _papeleriaContext.Articulos.FirstOrDefault(articulo => articulo.Id == id);
                return articuloEncontrado ?? throw new ArticuloNoEncontradoException($"No se encontro el articulo de Id: {id}");
            }
            catch (ArticuloNoEncontradoException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error desconocido: {ex.Message} (Trace: {ex.StackTrace})");
            }
        }

        public void Update(Articulo articuloEditado)
        {
            try
            {
                articuloEditado.EsValido();
                _papeleriaContext.Articulos.Update(articuloEditado);
                _papeleriaContext.SaveChanges();
            }
            catch (ArticuloNoValidoException)
            {
                throw;
            }catch (Exception ex)
            {
                throw new Exception($"Error desconocido: {ex.Message} (Trace: {ex.StackTrace})");
            }
        }

        public void Delete(int id)
        {
            try
            {
                Articulo articuloParaBorrar = this.FindById(id);
                _papeleriaContext.Articulos.Remove(articuloParaBorrar);
                _papeleriaContext.SaveChanges();
            }
            catch (ArticuloNoEncontradoException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error desconocido: {ex.Message} (Trace: {ex.StackTrace})");
            }
        }
        #endregion
    }
}

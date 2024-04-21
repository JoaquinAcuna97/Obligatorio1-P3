using Papeleria.AccesoDatos.Interfaces;
using Papeleria.LogicaNegocio.Entidades;
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
            catch (Exception)
            {
                //TODO: Articulo not valid exception
                throw;
            }
        }

        public IEnumerable<Articulo> FindAll()
        {
            if (!_papeleriaContext.Articulos.Any())
            {
                //TODO: Table empty exception
                throw new Exception("La tabla Articulos esta vacia");
            }

            return _papeleriaContext.Articulos;
        }

        public Articulo FindById(int id)
        {
            if (!_papeleriaContext.Articulos.Any())
            {
                //TODO: Table empty exception
                throw new Exception("La tabla Articulos esta vacia");
            }

            try
            {
                Articulo? articuloEncontrado = _papeleriaContext.Articulos.FirstOrDefault(articulo => articulo.Id == id);
                //TODO: Articulo no encontrado Exception
                return articuloEncontrado ?? throw new Exception($"No se encontro el articulo de Id: {id}");
            }
            catch (Exception)
            {
                //TODO: Articulo no encontrado exception
                throw;
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
            catch (Exception)
            {
                //TODO: Articulo no valido exception
                throw;
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
            catch (Exception)
            {
                //TODO: Articulo no encontrado exception
                throw;
            }
        }
        #endregion
    }
}

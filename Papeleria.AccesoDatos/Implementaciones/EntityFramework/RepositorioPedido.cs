using Papeleria.AccesoDatos.Interfaces;
using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.Implementaciones.EntityFramework
{
    public class RepositorioPedido : IRepositorioPedido
    {
        private readonly PapeleriaContext _papeleriaContext;

        public RepositorioPedido()
        {
            //Inyeccion de dependencia
            _papeleriaContext = new PapeleriaContext();
        }

        #region CRUD Operations
        public void Add(Pedido pedidoNuevo)
        {
            try
            {
                pedidoNuevo.EsValido();
                _papeleriaContext.Pedidos.Add(pedidoNuevo);
                _papeleriaContext.SaveChanges();
            }
            catch (Exception)
            {
                //TODO: Pedido no valido exception
                throw;
            }
        }

        public IEnumerable<Pedido> FindAll()
        {
            if (!_papeleriaContext.Pedidos.Any())
            {
                //TODO: Empty table exception
                throw new Exception("La tabla de Pedidos esta vacia");
            }

            return _papeleriaContext.Pedidos;
        }

        public Pedido FindById(int id)
        {
            if (!_papeleriaContext.Pedidos.Any())
            {
                //TODO: Empty table exception
                throw new Exception("La tabla de Pedidos esta vacia");
            }

            try
            {
                //TODO: Deberia ser un pedido DTO(?)
                Pedido? pedidoEncontrado = _papeleriaContext.Pedidos.FirstOrDefault(pedido => pedido.Id == id);
                //TODO: PEdido no encontrado exception
                return pedidoEncontrado ?? throw new Exception($"No se encontro el pedido de ID: {id}");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Pedido pedidoEditado)
        {
            try
            {
                pedidoEditado.EsValido();
                _papeleriaContext.Pedidos.Update(pedidoEditado);
                _papeleriaContext.SaveChanges();
            }
            catch (Exception)
            {
                //TODO: Pedido no valido exception
                throw;
            }
        }
        
        public void Delete(int id)
        {
            try
            {
                //TODO: Deberia ser un pedido DTO(?)
                Pedido pedidoEncontrado = this.FindById(id);
                _papeleriaContext.Pedidos.Remove(pedidoEncontrado);
                _papeleriaContext.SaveChanges();
            }
            catch (Exception)
            {
                //TODO: pedido no encontrado exception
                throw;
            }
        }
        #endregion
    }
}

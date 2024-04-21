using Papeleria.AccesoDatos.Interfaces;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Excepciones.Clientes;
using Papeleria.LogicaNegocio.Excepciones.Generales;
using Papeleria.LogicaNegocio.Excepciones.Pedidos;
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
            catch (PedidoNoValidoException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error desconocido: {ex.Message} (Trace: {ex.StackTrace})");
            }
        }

        public IEnumerable<Pedido> FindAll()
        {
            if (!_papeleriaContext.Pedidos.Any())
            {
                throw new DataBaseSetException("La tabla de Pedidos esta vacia");
            }

            return _papeleriaContext.Pedidos;
        }

        public Pedido FindById(int id)
        {
            if (!_papeleriaContext.Pedidos.Any())
            {
                throw new DataBaseSetException("La tabla de Pedidos esta vacia");
            }

            try
            {
                //TODO: Deberia ser un pedido DTO(?)
                Pedido? pedidoEncontrado = _papeleriaContext.Pedidos.FirstOrDefault(pedido => pedido.Id == id);
                return pedidoEncontrado ?? throw new PedidoNoEncontradoException($"No se encontro el pedido de ID: {id}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error desconocido: {ex.Message} (Trace: {ex.StackTrace})");
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
            catch (PedidoNoValidoException)
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
                //TODO: Deberia ser un pedido DTO(?)
                Pedido pedidoEncontrado = this.FindById(id);
                _papeleriaContext.Pedidos.Remove(pedidoEncontrado);
                _papeleriaContext.SaveChanges();
            }
            catch (PedidoNoEncontradoException)
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

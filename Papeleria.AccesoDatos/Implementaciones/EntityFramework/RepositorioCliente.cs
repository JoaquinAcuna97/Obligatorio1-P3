using Papeleria.AccesoDatos.Interfaces;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Excepciones.Clientes;
using Papeleria.LogicaNegocio.Excepciones.Generales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.Implementaciones.EntityFramework
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly PapeleriaContext _papeleriaContext;

        public RepositorioCliente()
        {
            _papeleriaContext = new PapeleriaContext();
        }

        #region CRUD Operations
        public void Add(Cliente clienteNuevo)
        {
            try
            {
                clienteNuevo.EsValido();
                _papeleriaContext.Clientes.Add(clienteNuevo);
                _papeleriaContext.SaveChanges();
            }
            catch (ClienteNoValidoException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error desconocido: {ex.Message} (Trace: {ex.StackTrace})");
            }
        }

        public IEnumerable<Cliente> FindAll()
        {
            try
            {
                return _papeleriaContext.Clientes;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error desconocido: {ex.Message} (Trace: {ex.StackTrace})");
            }
        }

        public Cliente FindById(int id)
        {
            if (!_papeleriaContext.Clientes.Any())
            {
                throw new DataBaseSetException("La tabla de Clientes esta vacia");
            }

            try
            {
                Cliente? clienteEncontrado = _papeleriaContext.Clientes.FirstOrDefault(cliente => cliente.Id == id);
                return clienteEncontrado ?? throw new ClienteNoEncontradoException($"No se encontro el cliente de ID: {id}");
            }
            catch (ClienteNoEncontradoException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error desconocido: {ex.Message} (Trace: {ex.StackTrace})");
            }
        }

        public void Update(Cliente clienteEditado)
        {
            try
            {
                clienteEditado.EsValido();
                _papeleriaContext.Clientes.Update(clienteEditado);
                _papeleriaContext.SaveChanges();
            }
            catch (ClienteNoValidoException)
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
                Cliente clienteParaBorrar = this.FindById(id);
                _papeleriaContext.Clientes.Remove(clienteParaBorrar);
                _papeleriaContext.SaveChanges(true);
            }
            catch (ClienteNoEncontradoException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error desconocido: {ex.Message} (Trace: {ex.StackTrace})");
            }
        }
        #endregion

        #region DML
        public Cliente BuscarClientePorRut(long rut)
        {

            if (!_papeleriaContext.Clientes.Any())
            {
                throw new DataBaseSetException("La tabla de Clientes esta vacia");
            }

            try
            {
                Cliente? clienteEncontrado = _papeleriaContext.Clientes.FirstOrDefault(cliente => cliente.RUT.RUTValor == rut);
                return clienteEncontrado ?? throw new ClienteNoEncontradoException($"No se pudo encontrar al cliente de RUT {rut}");
            }
            catch (ClienteNoEncontradoException)
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

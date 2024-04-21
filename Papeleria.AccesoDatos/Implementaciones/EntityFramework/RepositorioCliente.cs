using Papeleria.AccesoDatos.Interfaces;
using Papeleria.LogicaNegocio.Entidades;
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
            }catch (Exception)
            {
                //TODO: Excepcion personalizada cliente no valido
                throw;
            }
        }

        public IEnumerable<Cliente> FindAll()
        {
            try
            {
                return _papeleriaContext.Clientes;
            }catch(Exception)
            {
                throw;
            }
        }

        public Cliente FindById(int id)
        {
            if (!_papeleriaContext.Clientes.Any())
            {
                //TODO: Tabla vacia exception
                throw new Exception("La tabla de Clientes esta vacia");
            }

            Cliente? clienteEncontrado = _papeleriaContext.Clientes.FirstOrDefault(cliente => cliente.Id == id);
            //TODO: Cliente no encontrado exception
            return clienteEncontrado ?? throw new Exception($"No se encontro el cliente de ID: {id}");
        }

        public void Update(Cliente clienteEditado)
        {
            try
            {
                clienteEditado.EsValido();
                _papeleriaContext.Clientes.Update(clienteEditado);
                _papeleriaContext.SaveChanges();
            }
            catch (Exception)
            {
                //TODO: Cliente not valid exception
                throw;
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
            catch (Exception)
            {
                //TODO: Cliente no encontrado exception
                throw;
            }
        }
        #endregion

        #region DML
        public Cliente BuscarClientePorRut(long rut)
        {
            try
            {
                if (!_papeleriaContext.Clientes.Any())
                {
                    //TODO: Tabla vacia exception
                    throw new Exception("La tabla de Clientes esta vacia");
                }

                Cliente? clienteEncontrado = _papeleriaContext.Clientes.FirstOrDefault(cliente => cliente.RUT == rut);
                //TODO: Cliente no encontrado exception
                return clienteEncontrado ?? throw new Exception($"No se pudo encontrar al cliente de RUT {rut}");
            }
            catch (Exception)
            {
                //Cliente no encontrado exception
                throw;
            }
        }
        #endregion
    }
}

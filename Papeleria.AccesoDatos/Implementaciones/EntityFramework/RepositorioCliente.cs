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
        public List<Cliente> Clientes { get; set; }

        public void Add(Cliente item)
        {
            throw new NotImplementedException();
        }

        public Cliente BuscarClientePorRut(long rut)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> FindAll()
        {
            throw new NotImplementedException();
        }

        public Cliente FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente item)
        {
            throw new NotImplementedException();
        }
    }
}

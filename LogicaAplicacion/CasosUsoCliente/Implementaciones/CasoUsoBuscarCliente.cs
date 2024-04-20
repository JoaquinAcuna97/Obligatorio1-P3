using LogicaAplicacion.CasosUsoCliente.Interfaces;
using Papeleria.AccesoDatos.Interfaces;
using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUsoCliente.Implementaciones
{
    public class CasoUsoBuscarCliente : ICasoUsoBuscarCliente
    {
        public IRepositorioCliente RepositorioClientes { get; set; }

        public CasoUsoBuscarCliente(IRepositorioCliente repositorioClientes)
        {
            // Inyeccion de dependencia
            this.RepositorioClientes = repositorioClientes;
        }

        public Cliente BuscarClientePorRut(long rut)
        {
            return this.RepositorioClientes.BuscarClientePorRut(rut);
        }

        public Cliente BuscarClientePorId(int id)
        {
            return this.RepositorioClientes.FindById(id);
        }
    }
}

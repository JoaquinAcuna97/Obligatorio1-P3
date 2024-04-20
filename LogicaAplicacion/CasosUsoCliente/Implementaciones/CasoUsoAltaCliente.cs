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
    public class CasoUsoAltaCliente : ICasoUsoAltaCliente
    {
        public IRepositorioCliente RepositorioClientes { get; set; }

        public CasoUsoAltaCliente(IRepositorioCliente repositorioClientes)
        {
            // Inyeccion de dependencia
            this.RepositorioClientes = repositorioClientes;
        }

        public void AltaCliente(Cliente cliente)
        {
            this.RepositorioClientes.Add(cliente);
        }

    }
}

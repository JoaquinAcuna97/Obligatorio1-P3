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
    public class CasoUsoBajaCliente : ICasoUsoBajaCliente
    {
        public IRepositorioCliente RepositorioClientes { get; set; }

        public CasoUsoBajaCliente(IRepositorioCliente repositorioClientes)
        {
            // Inyeccion de dependencia
            this.RepositorioClientes = repositorioClientes;

        }

        public void BajaCliente(int id)
        {
            this.RepositorioClientes.Delete(id);
        }

    }
}

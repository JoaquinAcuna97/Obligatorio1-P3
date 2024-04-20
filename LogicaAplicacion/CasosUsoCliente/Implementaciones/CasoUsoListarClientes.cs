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
    public class CasoUsoListarClientes : ICasoUsoListarClientes
    {
        public IRepositorioCliente RepositorioClientes { get; set; }

        public CasoUsoListarClientes(IRepositorioCliente repositorioClientes)
        {
            // Inyeccion de dependencia
            this.RepositorioClientes = repositorioClientes;

        }

        public IEnumerable<Cliente> ListarClientes()
        {
            return this.RepositorioClientes.FindAll();
        }
    }

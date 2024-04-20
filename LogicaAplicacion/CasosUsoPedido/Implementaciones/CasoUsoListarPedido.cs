using LogicaAplicacion.CasosUsoPedido.Interfaces;
using Papeleria.AccesoDatos.Interfaces;
using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUsoPedido.Implementaciones
{
    public class CasoUsoListarPedido : ICasoUsoListarPedido
    {
        public IRepositorioPedido RepositorioPedidos { get; set; }

        public CasoUsoListarPedido(IRepositorioPedido repositorioPedidos)
        {
            /// Inyeccion de dependencia
            this.RepositorioPedidos = repositorioPedidos;
        }

        public IEnumerable<Pedido> ListarPedidos()
        {
            return this.RepositorioPedidos.FindAll();
        }

    }
}

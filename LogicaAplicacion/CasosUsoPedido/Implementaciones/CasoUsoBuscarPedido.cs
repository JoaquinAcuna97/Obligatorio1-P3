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
    public class CasoUsoBuscarPedido : ICasoUsoBuscarPedido
    {
        public IRepositorioPedido RepositorioPedidos { get; set; }

        public CasoUsoBuscarPedido(IRepositorioPedido repositorioPedidos)
        {
            // Inyeccion de dependencia
            this.RepositorioPedidos = repositorioPedidos;
        }

        public Pedido BuscarPedido(int id)
        {
            return this.RepositorioPedidos.FindById(id);
        }

    }
}

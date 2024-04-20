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
    public class CasoUsoEditarPedido : ICasoUsoEditarPedido
    {
        public IRepositorioPedido RepositorioPedidos { get; set; }

        public CasoUsoEditarPedido(IRepositorioPedido repositorioPedidos)
        {
            // Inyeccion de dependencia
            this.RepositorioPedidos = repositorioPedidos;
        }

        public void EditarPedido(Pedido pedido)
        {
            this.RepositorioPedidos.Update(pedido);
        }

    }
}

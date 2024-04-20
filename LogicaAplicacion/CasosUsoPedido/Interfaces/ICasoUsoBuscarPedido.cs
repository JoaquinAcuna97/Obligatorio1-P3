using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUsoPedido.Interfaces
{
    public interface ICasoUsoBuscarPedido
    {
        public Pedido BuscarPedido(int id);

    }
}

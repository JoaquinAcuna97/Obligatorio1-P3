using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.Pedidos
{
    public class PedidoNoValidoException : Exception
    {
        public PedidoNoValidoException() { }

        public PedidoNoValidoException(string? message) : base(message) { }

        public PedidoNoValidoException(string? message, Exception? innerException) : base(message, innerException) { }
    }
}

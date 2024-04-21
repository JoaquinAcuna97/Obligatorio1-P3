using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.Clientes
{
    public class ClienteNoEncontradoException : Exception
    {
        public ClienteNoEncontradoException() { }

        public ClienteNoEncontradoException(string? message) : base(message) { }

        public ClienteNoEncontradoException(string? message, Exception? innerException) : base(message, innerException) { }
    }
}

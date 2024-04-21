using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.Articulos
{
    public class ArticuloNoEncontradoException : Exception
    {
        public ArticuloNoEncontradoException()
        {
        }

        public ArticuloNoEncontradoException(string? message) : base(message)
        {
        }

        public ArticuloNoEncontradoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}

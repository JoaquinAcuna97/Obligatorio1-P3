using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.Usuario
{
    public class UsuarioNuloException : Exception
    {
        public UsuarioNuloException()
        {
        }

        public UsuarioNuloException(string? message) : base(message)
        {
        }

        public UsuarioNuloException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}

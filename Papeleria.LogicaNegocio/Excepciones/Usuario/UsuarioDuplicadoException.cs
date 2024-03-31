using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.Usuario
{
    public class UsuarioDuplicadoException : Exception
    {
        public UsuarioDuplicadoException()
        {
        }

        public UsuarioDuplicadoException(string? message) : base(message)
        {
        }

        public UsuarioDuplicadoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UsuarioDuplicadoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

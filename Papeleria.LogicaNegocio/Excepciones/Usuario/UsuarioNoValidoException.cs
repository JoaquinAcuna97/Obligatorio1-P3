using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.Usuario
{
    public class UsuarioNoValidoException : Exception
    {
        public UsuarioNoValidoException()
        {
        }

        public UsuarioNoValidoException(string? message) : base(message)
        {
        }

        public UsuarioNoValidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UsuarioNoValidoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

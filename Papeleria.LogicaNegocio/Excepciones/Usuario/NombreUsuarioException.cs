﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.Usuario
{
    public class NombreUsuarioException:UsuarioNoValidoException
    {
        public NombreUsuarioException()
        {
        }

        public NombreUsuarioException(string? message) : base(message)
        {
        }

        public NombreUsuarioException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NombreUsuarioException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

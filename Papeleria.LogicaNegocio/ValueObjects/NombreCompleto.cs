using Papeleria.LogicaNegocio.Excepciones.Usuario;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.ValueObjects
{
    [Owned]
    public class NombreCompleto
    {
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }

        public NombreCompleto(string nombre, string apellido) 
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.EsValido();
        }

        protected NombreCompleto() { }

        public void EsValido() 
        {
            if (this.Apellido == null)
            {
                throw new UsuarioNoValidoException("Apellido no puede ser vacío");
            }
            if (this.Nombre == null)
            {
                throw new UsuarioNoValidoException("Nombre no puede ser vacío");
            }
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            NombreCompleto otro = obj as NombreCompleto;

            return this.Nombre.Equals(otro.Nombre) && this.Apellido.Equals(otro.Apellido);
        }
    }
}

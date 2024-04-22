using Papeleria.LogicaNegocio.Excepciones.Usuario;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Papeleria.LogicaNegocio.ValueObjects
{
    [Owned]
    public class NombreCompleto : IValidable<NombreCompleto>
    {
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }

        public NombreCompleto(string nombre, string apellido) 
        {
            Nombre = nombre;
            Apellido = apellido;
            EsValido();
        }

        public void EsValido() 
        {
            ValidarNombre();
            ValidarApellido();
        }

        private void ValidarNombre()
        {
            string patronValido = @"^[a-zA-ZáéíóúÁÉÍÓÚüÜñÑ]+(?:[' -][a-zA-ZáéíóúÁÉÍÓÚüÜñÑ]+)*$";

            if (string.IsNullOrEmpty(Nombre))
            {
                throw new UsuarioNoValidoException("Nombre no puede ser vacío");
            } else if (!Regex.IsMatch(Nombre, patronValido))
            {
                throw new UsuarioNoValidoException("El nombre solo puede contener letras, espacios, apostrofes o guiones. Los caracteres especiales no pueden estar al principio ni al final.");
            }
        }

        private void ValidarApellido()
        {
            string patronValido = @"^[a-zA-ZáéíóúÁÉÍÓÚüÜñÑ]+(?:[' -][a-zA-ZáéíóúÁÉÍÓÚüÜñÑ]+)*$";

            if (string.IsNullOrEmpty(Apellido))
            {
                throw new UsuarioNoValidoException("Apellido no puede ser vacío");
            }
            else if (!Regex.IsMatch(Apellido, patronValido))
            {
                throw new UsuarioNoValidoException("El apellido solo puede contener letras, espacios, apostrofes o guiones. Los caracteres especiales no pueden estar al principio ni al final.");
            }
        }

        //TODO: Revisar posible simplificacion
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            NombreCompleto otro = obj as NombreCompleto;

            return this.Nombre.Equals(otro.Nombre) && this.Apellido.Equals(otro.Apellido);
        }
    }
}

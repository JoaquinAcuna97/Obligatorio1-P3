using Microsoft.EntityFrameworkCore;
using Papeleria.LogicaNegocio.Excepciones.Usuario;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.ValueObjects
{
    [Owned]
    public class ContraseniaEncriptada : IValidable<ContraseniaEncriptada>
    {
        public string ValorContrasenia { get; private set; }

        public ContraseniaEncriptada(string contrasenia)
        {
            ValorContrasenia = contrasenia;
            EsValido();
            ValorContrasenia = Encriptar(contrasenia);
        }

        private string Encriptar(string contrasenia)
        {
            //TODO: Metodo de encriptacion
            return contrasenia;
        }

        public void EsValido()
        {
            ValidarContrasenia();
        }

        private void ValidarContrasenia()
        {
            string patronValido = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[.,;!])[A-Za-z\d.,;!]{6,}$";
            if (!Regex.IsMatch(ValorContrasenia, patronValido))
            {
                throw new UsuarioNoValidoException("La contraseña debe tener al menos largo 6. Largo mínimo de 6 caracteres, al menos una letra mayúscula, una minúscula, un dígito y un carácter de puntuación (.,;!)");
            }
        }
    }
}

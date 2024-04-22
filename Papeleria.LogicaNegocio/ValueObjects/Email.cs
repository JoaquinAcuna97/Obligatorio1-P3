using Microsoft.EntityFrameworkCore;
using Papeleria.LogicaNegocio.Excepciones.Usuario;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using System.Text.RegularExpressions;

namespace Papeleria.LogicaNegocio.ValueObject
{
	[Owned]
	public class Email :IValidable<Email>
    {
		public string DireccionEmail { get; set; }

		public Email(string direccionEmail)
		{
			DireccionEmail = direccionEmail;
			EsValido();
		}

        #region Validations
        public void EsValido()
        {
			ValidarDireccionEmail();
        }

        private void ValidarDireccionEmail()
        {
            string patronValido = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(DireccionEmail))
            {
                throw new UsuarioNoValidoException("El email no puede ser vacio.");
            }else if (!Regex.IsMatch(DireccionEmail, patronValido))
            {
                throw new UsuarioNoValidoException("Ingrese un email valido");
            }
        }
        #endregion
    }

}


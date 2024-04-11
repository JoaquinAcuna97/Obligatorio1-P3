using Papeleria.LogicaNegocio.ValueObjects;
using Papeleria.LogicaNegocio.Excepciones.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades
{
    public class Usuario : IValidable<Usuario>
    {
        #region Propiedades
        public NombreCompleto NombreCompleto { get; set; }
        public int Id { get; set; }
        //TODO: Email tiene que ser unico
        public string Email { get; set;}

        public string Contrasena { get; set; }

        public string ContrasenaEncriptada { get; set; }

        public bool EsAdmin { get; set;}

        #endregion

        #region Métodos Constructores
        public Usuario(string nombre, string apellido, string email, bool esAdmin)
        {

            NombreCompleto = new NombreCompleto(nombre, apellido);
            Email = email;
            EsAdmin = esAdmin;
            EsValido(this);

        }

        public Usuario()
        {

        }
        #endregion

        #region Métodos que sobreescribimos de la clase Object y de la interfaz IEquatable
        override public string ToString()
        {
            return $"{this.NombreCompleto.Nombre} -- {this.NombreCompleto.Apellido}";
        }
        public bool Equals(Usuario? other)
        {
            if (other == null)
                throw new ArgumentNullException("Debe incluir el usuario a comparar");

            return this.Id == other.Id;
        }
        #endregion

        #region Métodos para validaciones
        public void EsValido(Usuario entidad)
        {
            // TODO: Validar Email
            /*
             El email debe tener el formato 
             habitual de las direcciones de correo electrónico
             */
            // TODO: Validar Nombre
            /*
            El nombre y el apellido solamente pueden contener caracteres 
            alfabéticos, espacio, apóstrofe o guión del medio. 
            Los caracteres no alfabéticos no pueden estar ubicados al 
            principio ni al final de la cadena.
             */

            // TODO: Validar Contrasena
            /*
             Al momento de registrarse el usuario deberá ingresar una contraseña que tenga un largo mínimo de 6 
            caracteres, al menos una letra mayúscula, una minúscula, un dígito y un carácter de puntuación: punto, punto y 
            coma, coma, signo de admiración de cierre. La contraseña no tiene por qué ser única, y deberá almacenarse 
            encriptada. 
            El método de encriptación de la contraseña será investigado mediante una inteligencia artificial por parte del 
            equipo de desarrollo. 
            A los efectos de favorecer el testing, la contraseña también se almacenará sin encriptar
             */
            if (entidad == null)
                throw new UsuarioNuloException("El Usuario no puede ser nulo");
            this.NombreCompleto.EsValido();
        }

        public void EsValido()
        {
            try
            {
                EsValido(this);

            }
            catch (Exception ex)
            {

                throw new UsuarioNoValidoException("Estoy capturando en EsValido", ex);
            }
        }
        #endregion
    }
}

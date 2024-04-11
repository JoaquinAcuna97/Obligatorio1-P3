using Papeleria.LogicaNegocio.ValueObjects;
using Papeleria.LogicaNegocio.Excepciones.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using System.Text.RegularExpressions;
using Papeleria.LogicaNegocio.ValueObject;
using Microsoft.EntityFrameworkCore;

namespace Papeleria.LogicaNegocio.Entidades
{
    [Index(nameof(Email), IsUnique = true)]

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
        public void ValidarEmail(string email) {
            // Patrón de expresión regular para validar una dirección de correo electrónico
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Comprueba si el formato del correo electrónico coincide con el patrón
            if (!Regex.IsMatch(email, pattern)) {
                throw new Exception("Email invalido");
            }
        }
        public void ValidarStringAlfaNum(string input, string tipo)
        {
            // Patrón de expresión regular para validar el string
            string pattern = @"^[a-zA-Z][a-zA-Z\s'-]*(?<!['-])$";

            // Comprueba si el formato del string coincide con el patrón
            if (!Regex.IsMatch(input, pattern))
            {
                throw new Exception(tipo+ " invalido");
            }
        }
        public void ValidarNombre(string nombre)
        {
            this.ValidarStringAlfaNum(nombre, "Nombre");
        }
        public void ValidarApellido(string apellido)
        {
            this.ValidarStringAlfaNum(apellido, "Apellido");
        }

        public void ValidarPassword(string password)
        {
            // Patrón de expresión regular para validar la contraseña
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[.,;!])[A-Za-z\d.,;!]{6,}$";

            // Comprueba si la contraseña coincide con el patrón
            if (!Regex.IsMatch(password, pattern))
            {
                throw new Exception("Contraseña invalida, debe contener mínimo de 6 caracteres, al menos una letra mayúscula, una minúscula, un dígito y un carácter de puntuación");
            }
        }
        #region Métodos para validaciones
        public void EsValido(Usuario entidad)
        {
            // TODO: Validar Email
            /*
             El email debe tener el formato 
             habitual de las direcciones de correo electrónico y debe ser unico
             */
            this.ValidarEmail(entidad.Email);
            // TODO: Validar Nombre
            /*
            El nombre y el apellido solamente pueden contener caracteres 
            alfabéticos, espacio, apóstrofe o guión del medio. 
            Los caracteres no alfabéticos no pueden estar ubicados al 
            principio ni al final de la cadena.
             */
            this.ValidarNombre(entidad.NombreCompleto.Nombre);
            this.ValidarApellido(entidad.NombreCompleto.Apellido);


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
            this.ValidarPassword(entidad.Contrasena);


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

using Papeleria.LogicaNegocio.ValueObjects;
using Papeleria.LogicaNegocio.Excepciones.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Entidades
{
    public class Usuario
    {
        #region Propiedades
        public int Id { get; set; }

        public NombreCompleto NombreCompleto { get; set; }

        public string Email { get; set;}

        public string Contrasena { get; set; }

        public string ContrasenaEncriptada { get; set; }

        public bool EsAdmin { get; set;}

        #endregion

        #region Métodos Constructores
        public Usuario(string nombre, string apellido, string email, string contrasenia, bool esAdmin)
        {

            this.NombreCompleto = new NombreCompleto(nombre, apellido);
            this.Email = email;
            this.Contrasena = contrasenia;
            this.ContrasenaEncriptada = contrasenia;
            this.EsAdmin = esAdmin;
            EsValido(this);

        }

        #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Usuario() { }
        #pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        #endregion

        #region Métodos que sobreescribimos de la clase Object y de la interfaz IEquatable

        public bool Equals(Usuario? other)
        {
            ArgumentNullException.ThrowIfNull(other);

            return this.Id == other.Id;
        }
        public override string ToString()
        {
            return $"{this.NombreCompleto.Nombre} -- {this.NombreCompleto.Apellido}";
        }
        #endregion

        #region Métodos para validaciones
        public void EsValido(Usuario unUsuario)
        {
            if (unUsuario == null)
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

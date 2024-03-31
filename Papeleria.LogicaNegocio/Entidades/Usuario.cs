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
        public NombreCompleto NombreCompleto { get; set; }
        public int Id { get; set; }

        public string Email { get; set;}

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

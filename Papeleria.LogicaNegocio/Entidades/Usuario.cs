using Papeleria.LogicaNegocio.ValueObjects;
using Papeleria.LogicaNegocio.Excepciones.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Papeleria.LogicaNegocio.ValueObject;

namespace Papeleria.LogicaNegocio.Entidades
{
    public class Usuario
    {
        #region Properties
        public int Id { get; set; }

        public NombreCompleto NombreCompleto { get; set; }

        public Email Email { get; set;}

        public string Contrasenia { get; set; }

        public string ContraseniaEncriptada { get; set; }

        public bool EsAdmin { get; set;}

        #endregion

        #region Métodos Constructores
        public Usuario(string nombre, string apellido, string email, string contrasenia, bool esAdmin)
        {

            NombreCompleto = new NombreCompleto(nombre, apellido);
            Email = new Email(email);
            Contrasenia = contrasenia;
            ContraseniaEncriptada = contrasenia;
            EsAdmin = esAdmin;
            //TODO: revisar validaciones
            //EsValido();

        }
        #endregion

        #region Validations
        
        public static void EsValido(Usuario unUsuario)
        {
            if (unUsuario == null)
                throw new UsuarioNuloException("El Usuario no puede ser nulo");
            
            unUsuario.NombreCompleto.EsValido();
        }
        #endregion

        #region Overrided Methods
        public bool Equals(Usuario? otroUsuario)
        {
            if (otroUsuario == null)
                throw new UsuarioNuloException("El usuario a comparar no puede ser nulo");

            return Id == otroUsuario.Id;
        }

        public override string ToString()
        {
            return $"ID: {Id}, {NombreCompleto.Nombre} -- {NombreCompleto.Apellido}";
        }
        #endregion
    }
}

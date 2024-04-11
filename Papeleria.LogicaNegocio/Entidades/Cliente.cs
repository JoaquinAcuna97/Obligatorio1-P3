using Papeleria.LogicaNegocio.ValueObjects;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.ValueObject;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades
{
	public class Cliente : IValidable<Cliente>
	{
		public long RUT;

		public string RazonSocial;

		public Direccion Direccion;

		public List<Usuario> Usuarios;

		public double TotalAcumulado;

		private Direccion[] direccion;

		private Usuario[] usuario;

        public void EsValido()
        {
            // TODO: Validar Rut 12 Digitos y direccion 
            /*
			 De los que se conoce la raz�n social, el RUT (Registro �nico Tributario, un n�mero de 12 d�gitos asignado por 
			DGI) y su direcci�n. La direcci�n debe incluir la calle, n�mero y ciudad, e interesa conocer la distancia en 
			kil�metros desde el dep�sito de la papeler�a.
			 */
            throw new NotImplementedException();
        }
    }

}


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
			 De los que se conoce la razón social, el RUT (Registro Único Tributario, un número de 12 dígitos asignado por 
			DGI) y su dirección. La dirección debe incluir la calle, número y ciudad, e interesa conocer la distancia en 
			kilómetros desde el depósito de la papelería.
			 */
            throw new NotImplementedException();
        }
    }

}


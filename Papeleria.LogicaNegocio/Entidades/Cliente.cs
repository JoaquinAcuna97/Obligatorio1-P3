using Papeleria.LogicaNegocio.ValueObjects;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.ValueObject;

namespace Papeleria.LogicaNegocio.Entidades
{
	public class Cliente
	{
		public long RUT;

		public string RazonSocial;

		public Direccion Direccion;

		public List<Usuario> Usuarios;

		public double TotalAcumulado;

		private Direccion[] direccion;

		private Usuario[] usuario;

	}

}


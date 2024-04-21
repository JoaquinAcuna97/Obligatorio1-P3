using Microsoft.EntityFrameworkCore;

namespace Papeleria.LogicaNegocio.ValueObject
{

	[Owned]
	public class Direccion
	{
		public string Calle;

		public int Numero;

		public string Ciudad;

		public int Distancia;

	}

}


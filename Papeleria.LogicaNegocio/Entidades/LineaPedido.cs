using Papeleria.LogicaNegocio.Entidades;

namespace Papeleria.LogicaNegocio.Entidades
{
	public class LineaPedido : Articulo
	{
		public Articulo Articulo;

		public int Cantidad;

		public double PrecioUnitario;

		private Articulo articulo;

	}

}


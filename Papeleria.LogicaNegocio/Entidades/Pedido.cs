using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Enumerados;

namespace Papeleria.LogicaNegocio.Entidades
{
	public abstract class Pedido : Articulo
	{
		public static double s_IVA;

		public Date FechaPrometida;

		public Date FechaCreado;

		public int Id;

		public Cliente Cliente;

		public double Total;

		public double IVAAplicado;

		public List<LineaPedido> Lineas;

		public Date FechaEntregado;

		public Estado Estado;

		private Cliente cliente;

		private LineaPedido[] lineaPedido;

		public abstract double CalcularTotal();

	}

}


using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Enumerados;

namespace Papeleria.LogicaNegocio.Entidades
{
	public abstract class Pedido : Articulo
	{
        #region Properies
        public static double s_IVA;

		public int Id;

		public Date FechaPrometidaz;

		public Date FechaCreado;

		public Cliente Cliente;

		public double Total;

		public double IVAAplicado;

		public List<LineaPedido> Lineas;

		public Date FechaEntregado;

		public Estado Estado;
        #endregion

        #region Methods definitions
        public abstract double CalcularTotal();
        #endregion
    }

}


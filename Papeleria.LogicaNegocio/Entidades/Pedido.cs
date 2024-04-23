using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Enumerados;

namespace Papeleria.LogicaNegocio.Entidades
{
	public abstract class Pedido
	{
        #region Properies
		//TODO: Pasar esto a archivo de configuracion
        public static double s_IVA = 22;

		public int Id;

		public DateTime FechaPrometida;

		public DateTime FechaCreado;

		public Cliente Cliente;

		public double Total;

		public double IVAAplicado;

		public List<LineaPedido> Lineas;

		public DateTime? FechaEntregado;

		public Estado Estado;
        #endregion

		protected Pedido( DateTime fechaPrometida, Cliente cliente)
		{
			FechaPrometida = fechaPrometida;
			FechaCreado = DateTime.Now;
			Cliente = cliente;
			Total = 0;
			IVAAplicado = s_IVA;
			Lineas = [];
			FechaEntregado = null;
			Estado = Estado.Nuevo;
		}

        #region Methods definitions
        public virtual double CalcularTotal()
		{	
			//TODO: Metodo para calcular el total de los pedidos
			double total = 0;
			return total;
		}
        #endregion
    }

}


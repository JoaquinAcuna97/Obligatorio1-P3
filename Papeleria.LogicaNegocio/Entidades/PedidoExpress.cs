using Papeleria.LogicaNegocio.Entidades;

namespace Papeleria.LogicaNegocio.Entidades
{
	public class PedidoExpress : Pedido
	{
		//TODO: Pasar esto a archivo de configuracion
		public static int s_PlazoMaximo;

        public PedidoExpress(DateTime fechaPrometida, Cliente cliente) : base(fechaPrometida, cliente)
        {
        }

        public override double CalcularTotal()
		{
			double totalPedidoBase = base.CalcularTotal();

			TimeSpan diferenciaFechas = FechaPrometida - FechaCreado;
			int diferenciaDias = diferenciaFechas.Days;

			return diferenciaDias < 1 ? totalPedidoBase *= 1.15 : totalPedidoBase *= 1.1;
		}

	}

}


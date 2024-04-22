using Papeleria.LogicaNegocio.Entidades;

namespace Papeleria.LogicaNegocio.Entidades
{
	public class PedidoExpress : Pedido
	{
		public static int s_PlazoMaximo;

		public override double CalcularTotal()
		{
			return 0;
		}

	}

}


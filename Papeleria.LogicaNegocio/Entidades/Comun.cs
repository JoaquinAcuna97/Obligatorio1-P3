using Papeleria.LogicaNegocio.Entidades;

namespace Papeleria.LogicaNegocio.Entidades
{
	public class Comun : Pedido
	{
		public static int s_PlazoMinimo;

        public override double CalcularTotal()
        {
            throw new NotImplementedException();
        }
    }

}


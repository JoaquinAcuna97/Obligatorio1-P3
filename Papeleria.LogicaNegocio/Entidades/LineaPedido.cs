using Papeleria.LogicaNegocio.Entidades;

namespace Papeleria.LogicaNegocio.Entidades
{
    public class LineaPedido : Articulo
	{
		public Articulo Articulo;

		public int Cantidad;

		public double PrecioUnitario;

		private Articulo articulo;

        public LineaPedido(int id, string nombre, string descripcion, string codigo, double precio, long stock) : base(id, nombre, descripcion, codigo, precio, stock)
        {
        }
    }

}


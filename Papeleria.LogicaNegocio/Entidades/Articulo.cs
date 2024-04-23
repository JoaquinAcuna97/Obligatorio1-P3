using Papeleria.LogicaNegocio.InterfacesEntidades;
using Papeleria.LogicaNegocio.ValueObjects;

namespace Papeleria.LogicaNegocio.Entidades
{
    public class Articulo : IValidable<Articulo>
	{
        #region Properties
        public int Id { get; set; }

		public NombreArticulo Nombre { get; set; }

		public DescripcionArticulo Descripcion { get; set; }

        public CodigoArticulo Codigo { get; set; }

        public double Precio { get; set; }

        public long Stock { get; set; }
        #endregion

        #region Constructors
        public Articulo (int id, string nombre, string descripcion, string codigo, double precio, long stock)
        {
            Id = id;
            Nombre = new NombreArticulo(nombre);
            Descripcion = new DescripcionArticulo(descripcion);
            Codigo = new CodigoArticulo(codigo);
            Precio = precio;
            Stock = stock;
        }

        #endregion

        #region Methods
        public void EsValido()
        {
            //TODO: Validaciones necesarias
        }
        #endregion
    }

}


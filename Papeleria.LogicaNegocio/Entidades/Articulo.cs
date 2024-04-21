using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades
{
    public class Articulo : IValidable<Articulo>
	{
        #region Properties
        public int Id { get; set; }

		public string Nombre { get; set; }

		public string Descripcion { get; set; }

        public string Codigo { get; set; }

        public double Precio { get; set; }

        public long Stock { get; set; }
        #endregion

        #region Constructors
        public Articulo (int id, string nombre, string descripcion, string codigo, double precio, long stock)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Codigo = codigo;
            Precio = precio;
            Stock = stock;
        }

        public Articulo() { }
        #endregion

        #region Methods
        public void EsValido()
        {
            //TODO: Validaciones necesarias
        }
        #endregion
    }

}


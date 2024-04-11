using Microsoft.EntityFrameworkCore;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using Papeleria.LogicaNegocio.ValueObject;
using System.ComponentModel.DataAnnotations;

namespace Papeleria.LogicaNegocio.Entidades
{
    [Index(nameof(Nombre), IsUnique = true)]
    public class Articulo : IValidable<Articulo>
	{
		//TODO: el nombre debe ser unico
		[Required]
		public string Nombre;

		public string Descripcion;

		public string Codigo;

		public double Precio;

		public long Stock;

        public void EsValido()
        {
            //TODO: Validar Nombre (no vacío y único) con mínimo de 10 y máximo de 200
            // TODO: Validar  la descripción (con un largo mínimo de 5 caracteres)
            /* TODO: Validar Codigo
			código que le pone el proveedor
			(es el que puede utilizarse como código de barras, tiene 13 dígitos 
			significativos)
			Validar que el código no sea  vacío y que no exista otro Artículo con el mismo código ni con el mismo nombre.
			El código deberá tener 13 dígitos
			 */
            throw new NotImplementedException();
        }
    }

}


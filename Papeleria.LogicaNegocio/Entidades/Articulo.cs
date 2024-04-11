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
            //TODO: Validar Nombre (no vac�o y �nico) con m�nimo de 10 y m�ximo de 200
            // TODO: Validar  la descripci�n (con un largo m�nimo de 5 caracteres)
            /* TODO: Validar Codigo
			c�digo que le pone el proveedor
			(es el que puede utilizarse como c�digo de barras, tiene 13 d�gitos 
			significativos)
			Validar que el c�digo no sea  vac�o y que no exista otro Art�culo con el mismo c�digo ni con el mismo nombre.
			El c�digo deber� tener 13 d�gitos
			 */
            throw new NotImplementedException();
        }
    }

}


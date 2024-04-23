using Microsoft.EntityFrameworkCore;
using Papeleria.LogicaNegocio.Excepciones.Clientes;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.ValueObject
{

	[Owned]
    public class Direccion : IValidable<Direccion>
	{
		public string Calle { get; private set; }

		public int Numero { get; private set; }

        public string Ciudad { get; private set; }

        public int Distancia { get; private set; }

		public Direccion(string calle, int numero, string ciudad, int distancia) 
		{
			Calle = calle;
			Numero = numero;
			Ciudad = ciudad;
			Distancia = distancia;
		}

        public void EsValido()
        {
            ValidarCalle();
            ValidarNumero();
            ValidarCiudad();
            ValidarDistancia();
        }

        private void ValidarDistancia()
        {
            if(Distancia == 0)
            {
                throw new ClienteNoValidoException("La distancia debe ser mayor a 0");
            }
        }

        private void ValidarCiudad()
        {
            if (string.IsNullOrEmpty(Ciudad))
            {
                throw new ClienteNoValidoException("Debe ingresar una ciudad");
            }
        }

        private void ValidarNumero()
        {
            if (Numero <= 0 )
            {
                throw new ClienteNoValidoException("Debe ingresar un numero de puerta valido");
            }
        }

        private void ValidarCalle()
        {
            if (string.IsNullOrEmpty(Calle))
            {
                throw new ClienteNoValidoException("Debe ingresar una calle");
            }
        }
    }

}


using Microsoft.EntityFrameworkCore;
using Papeleria.LogicaNegocio.Excepciones.Articulos;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.ValueObjects
{
    [Owned]
    public class NombreArticulo : IValidable<NombreArticulo>
    {
        public string NombreArticuloValor {  get; private set; }

        public NombreArticulo(string nombreArticulo)
        {
            NombreArticuloValor = nombreArticulo;
            EsValido();
        }

        public void EsValido()
        {
            ValidarNombre();
        }

        private void ValidarNombre()
        {
            if (string.IsNullOrEmpty(NombreArticuloValor))
            {
                throw new ArticuloNoValidoException("Debe ingresar un nombre para el articulo");
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Papeleria.LogicaNegocio.Excepciones.Articulos;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.ValueObjects
{
    [Owned]
    public class CodigoArticulo : IValidable<CodigoArticulo>
    {
        public string CodigoArticuloValor {  get; private set; }

        public CodigoArticulo(string codigoArticuloValor)
        {
            CodigoArticuloValor = codigoArticuloValor;
            EsValido();
        }

        public void EsValido()
        {
            ValidarCodigo();
        }

        private void ValidarCodigo()
        {
            string patronValido = @"\d{13+}";
            if(!Regex.IsMatch(CodigoArticuloValor,patronValido))
                throw new ArticuloNoValidoException("El código del artículo debe tener 13 carácteres");
        }
    }
}

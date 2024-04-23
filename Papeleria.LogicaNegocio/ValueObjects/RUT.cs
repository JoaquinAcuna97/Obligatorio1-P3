using Microsoft.EntityFrameworkCore;
using Papeleria.LogicaNegocio.Excepciones.Clientes;
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
    public class RUT : IValidable<RUT>
    {
        public long RUTValor {  get; private set; }

        public RUT(long rut)
        {
            RUTValor = rut;
            EsValido();
        }

        public void EsValido()
        {
            ValidarRUT();
        }

        private void ValidarRUT()
        {
            string patronValido = @"\d{12}";

            if (RUTValor < 0 || !Regex.IsMatch(RUTValor.ToString(), patronValido))
            {
                throw new ClienteNoValidoException($"El RUT ingresado {RUTValor} no es valido.");
            }
        }
    }
}

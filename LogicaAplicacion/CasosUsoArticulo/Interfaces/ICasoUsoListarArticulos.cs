using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUsoArticulo.Interfaces
{
    public interface ICasoUsoListarArticulos
    {
        public IEnumerable<Articulo> LsitarArticulos();
    }
}

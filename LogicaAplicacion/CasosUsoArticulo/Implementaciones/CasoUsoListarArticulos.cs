using LogicaAplicacion.CasosUsoArticulo.Interfaces;
using Papeleria.AccesoDatos.Interfaces;
using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUsoArticulo.Implementaciones
{
    public class CasoUsoListarArticulos : ICasoUsoListarArticulos
    {
        public IRepositorioArticulo RepositorioArticulos { get; set; }

        public CasoUsoListarArticulos(IRepositorioArticulo repositorioArticulos)
        {
            // Inyeccion de dependencia
            this.RepositorioArticulos = repositorioArticulos;
        }

        public IEnumerable<Articulo> LsitarArticulos()
        {
            return this.RepositorioArticulos.FindAll();
        }
    }
}

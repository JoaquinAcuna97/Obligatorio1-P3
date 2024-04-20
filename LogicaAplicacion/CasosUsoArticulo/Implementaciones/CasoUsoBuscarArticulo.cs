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
    public class CasoUsoBuscarArticulo : ICasoUsoBuscarArticulo
    {
        public IRepositorioArticulo RepositorioArticulos { get; set; }

        public CasoUsoBuscarArticulo(IRepositorioArticulo repositorioArticulos)
        {
            // Inyeccion de dependencia
            this.RepositorioArticulos = repositorioArticulos;

        }

        public Articulo BuscarArticulo(int id)
        {
            return this.RepositorioArticulos.FindById(id);
        }
    }
}

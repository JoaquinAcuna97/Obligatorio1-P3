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
    public class CasoUsoEditarArticulo(IRepositorioArticulo repositorioArticulos) : ICasoUsoEditarArticulo
    {
        public IRepositorioArticulo RepositorioArticulos { get; set; } = repositorioArticulos;

        public void EditarArticulo(Articulo articulo)
        {
            this.RepositorioArticulos.Update(articulo);
        }
    }
}

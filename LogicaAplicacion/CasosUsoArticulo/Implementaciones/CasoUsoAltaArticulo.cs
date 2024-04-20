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
    public class CasoUsoAltaArticulo : ICasoUsoAltaArticulo
    {
        public IRepositorioArticulo RepositorioArticulos { get; set; }

        public CasoUsoAltaArticulo(IRepositorioArticulo repositorioArticulos)
        {
            this.RepositorioArticulos = repositorioArticulos;
        }

        public void AltaArticulo(Articulo articuloNuevo)
        {
            RepositorioArticulos.Add(articuloNuevo);
        }
    }
}

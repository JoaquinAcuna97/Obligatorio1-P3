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
    public class CasoUsoBajaArticulo : ICasoUsoBajaArticulo
    {
        public IRepositorioArticulo RepositorioArticulos { get; set; }

        public CasoUsoBajaArticulo(IRepositorioArticulo repositorioArticulos)
        {
            // Inyeccion de dependencia
            this.RepositorioArticulos = repositorioArticulos;
        }

        public void BajaArticulo(int id)
        {
            this.RepositorioArticulos.Delete(id);
        }
    }
}

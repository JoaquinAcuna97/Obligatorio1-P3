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
    public class CasoUsoBajaArticulo(IRepositorioArticulo repositorioArticulos) : ICasoUsoBajaArticulo
    {
        public IRepositorioArticulo RepositorioArticulos { get; set; } = repositorioArticulos;

        public void BajaArticulo(int id)
        {
            this.RepositorioArticulos.Delete(id);
        }
    }
}

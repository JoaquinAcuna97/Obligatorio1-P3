using LogicaAplicacion.CasosUsoUsuario.Interfaces;
using Papeleria.AccesoDatos.Interfaces;
using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUsoUsuario.Implementaciones
{
    public class CasoUsoBajaUsuario : ICasoUsoBajaUsuario
    {
        public IRepositorioUsuario RepositorioUsuarios { get; set; }

        public CasoUsoBajaUsuario(IRepositorioUsuario repositorioUsuarios)
        {
            // Inyeccion de dependencia
            this.RepositorioUsuarios = repositorioUsuarios;
        }

        public void BajaUsuario(int id)
        {
            this.RepositorioUsuarios.Delete(id);
        }

    }
}

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
    public class CasoUsoBuscarUsuario : ICasoUsoBuscarUsuario
    {
        public IRepositorioUsuario RepositorioUsuarios { get; set; }

        public CasoUsoBuscarUsuario(IRepositorioUsuario repositorioUsuarios)
        {
            // Inyeccion de dependencia
            this.RepositorioUsuarios = repositorioUsuarios;
        }

        public Usuario BuscarUsuario(int id)
        {
            return this.RepositorioUsuarios.FindById(id);
        }

    }
}

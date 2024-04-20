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
    public class CasoUsoEditarUsuario : ICasoUsoEditarUsuario
    {
        public IRepositorioUsuario RepositorioUsuarios { get; set; }

        public CasoUsoEditarUsuario(IRepositorioUsuario repositorioUsuarios)
        {
            // Inyeccion de dependencia
            this.RepositorioUsuarios = repositorioUsuarios;
        }

        public void EditarUsuario(Usuario usuario)
        {
            this.RepositorioUsuarios.Update(usuario);
        }

    }
}

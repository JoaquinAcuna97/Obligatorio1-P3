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
    public class CasoUsoAltaUsuario : ICasoUsoAltaUsuario
    {
        public IRepositorioUsuario RepositorioUsuarios { get; set; }

        public CasoUsoAltaUsuario(IRepositorioUsuario repositorioUsuarios)
        {
            // Inyeccion de dependencia
            this.RepositorioUsuarios = repositorioUsuarios;
        }

        public void AltaUsuario(Usuario usuario)
        {
            this.RepositorioUsuarios.Add(usuario);
        }

    }
}

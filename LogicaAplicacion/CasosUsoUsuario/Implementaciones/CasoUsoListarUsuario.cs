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
    public class CasoUsoListarUsuario : ICasoUsoListarUsuario
    {
        public IRepositorioUsuario RepositorioUsuarios { get; set; }

        public CasoUsoListarUsuario(IRepositorioUsuario repositorioUsuarios)
        {
            // Inyeccion de dependencia
            this.RepositorioUsuarios = repositorioUsuarios;
        }

        public IEnumerable<Usuario> ListarUsuario()
        {
            return this.RepositorioUsuarios.FindAll();
        }

    }
}

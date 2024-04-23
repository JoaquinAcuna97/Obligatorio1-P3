using LogicaAplicacion.CasosUsoLogin.Interfaces;
using Papeleria.AccesoDatos.Interfaces;
using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUsoLogin.Implementaciones
{
    public class CasoUsoLogin : ICasoUsoLogin
    {
        public IRepositorioUsuario RepositorioUsuarios {  get; }

        public CasoUsoLogin(IRepositorioUsuario repositorioUsuarios)
        {
            //Inyeccion de dependencia
            RepositorioUsuarios = repositorioUsuarios;
        }

        public Usuario Loguear(string email, string password)
        {
            return RepositorioUsuarios.FindByEmail(email);
        }
    }
}

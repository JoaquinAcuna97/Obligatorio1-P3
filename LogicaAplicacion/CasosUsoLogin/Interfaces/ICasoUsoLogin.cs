using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUsoLogin.Interfaces
{
    public interface ICasoUsoLogin
    {
        public Usuario Loguear(string email, string password);
    }
}

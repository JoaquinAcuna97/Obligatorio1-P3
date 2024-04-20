using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUsoUsuario.Interfaces
{
    public interface ICasoUsoBuscarUsuario
    {
        public Usuario BuscarUsuario(string email);

    }
}

using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUsoCliente.Interfaces
{
    public interface ICasoUsoBuscarCliente
    {
        public Cliente BuscarClientePorRut(long rut);
        public Cliente BuscarClientePorId(int id);

    }
}

﻿using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.Interfaces
{
    public interface IRepositorioCliente : IRepositorioCRUD<Cliente>
    {
        public Cliente BuscarClientePorRut(long rut);
    }
}

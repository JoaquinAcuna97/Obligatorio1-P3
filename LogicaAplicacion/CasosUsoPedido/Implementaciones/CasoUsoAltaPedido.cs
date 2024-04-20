﻿using LogicaAplicacion.CasosUsoPedido.Interfaces;
using Papeleria.AccesoDatos.Interfaces;
using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUsoPedido.Implementaciones
{
    public class CasoUsoAltaPedido : ICasoUsoAltaPedido
    {
        public IRepositorioPedido RepositorioPedidos { get; set; }

        public CasoUsoAltaPedido(IRepositorioPedido repositorioPedidos)
        {
            // Inyeccion de dependencia
            this.RepositorioPedidos = repositorioPedidos;
        }

        public void AltaPedido(Pedido pedido)
        {
            this.RepositorioPedidos.Add(pedido);
        }

    }
}

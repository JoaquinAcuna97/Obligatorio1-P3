using Papeleria.AccesoDatos.Interfaces;
using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.Implementaciones.EntityFramework
{
    public class RepositorioPedido : IRepositorioPedido
    {
        public List<Pedido> Pedidos { get; set; }


        public void Add(Pedido item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> FindAll()
        {
            throw new NotImplementedException();
        }

        public Pedido FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Pedido item)
        {
            throw new NotImplementedException();
        }
    }
}

using Papeleria.AccesoDatos.Interfaces;
using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.Implementaciones.EntityFramework
{
    public class RepositorioArticulo : IRepositorioArticulo
    {
        public List<Articulo> Articulos { get; set; }


        public void Add(Articulo item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Articulo> FindAll()
        {
            throw new NotImplementedException();
        }

        public Articulo FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Articulo item)
        {
            throw new NotImplementedException();
        }
    }
}

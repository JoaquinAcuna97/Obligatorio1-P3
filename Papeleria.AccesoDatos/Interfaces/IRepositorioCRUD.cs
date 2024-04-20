using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.Interfaces
{
    public interface IRepositorioCRUD<T>
    {
        public void Add(T item);

        public void Update(T item);

        public void Delete(int id);

        public IEnumerable<T> FindAll();

        public T FindById(int id);

    }
}

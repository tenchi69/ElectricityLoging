using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityLoging.EF.Repositories
{
    public interface IGenericRepository<T>
    {
        public T Get(int id);
        public void Save(T entity);
        public void Delete(int id);
        public List<T> GetAll();

    }
}

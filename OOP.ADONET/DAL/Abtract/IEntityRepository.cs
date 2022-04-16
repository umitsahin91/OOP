using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ADONET.DAL.Abtract
{
    public  interface IEntityRepository<T>
        where T:class, new()
    {
        void Add(T entity);
        void Update(T entity);
        List<T> GetAll();
        void Delete(T entity);
        
    }
}

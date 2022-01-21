using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities.Abstract;

namespace Northwind.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);// filter can be null
        T Get(Expression<Func<T, bool>> filter);// filter can not be null
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

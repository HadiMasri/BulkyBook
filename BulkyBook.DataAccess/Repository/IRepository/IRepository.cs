using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    //it's a generic Interface 
    //generics allow you to write a class or method that can work with any data type.
    public interface IRepository<T> where T:class
    {
        T Get(int id);


        //IEnumerable in C# is an interface that defines one method
        //This allows readonly access to a collection then a collection that implements IEnumerable can be used with a for-each statement.
        IEnumerable<T> GetAll(
            Expression<Func<T,bool>> filter = null,
            Func<IQueryable<T>,IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
            );

        T GetFirstOrDefault(
      Expression<Func<T, bool>> filter = null,
      string includeProperties = null
      );

        void Add(T entity);
        void Remove(int id);

        void RemoveRange(IEnumerable<T> entity);
    }
}

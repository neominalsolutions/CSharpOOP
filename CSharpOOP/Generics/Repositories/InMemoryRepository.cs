using CSharpOOP.Generics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Generics.Repositories
{
  

  public abstract class InMemoryRepository<TEntity, TKey> : IRepository<TEntity, TKey>
  where TEntity : Entity<TKey>
  where TKey : IComparable
  {

    //public abstract void Insert(TEntity entity);
    public void Insert(TEntity entity)
    {
      throw new NotImplementedException();
    }
  }


  
}

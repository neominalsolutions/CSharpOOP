using CSharpOOP.Generics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Generics.Repositories
{

  public interface IRepository<TEntity, TKey>
 where TEntity : Entity<TKey>
 where TKey : IComparable
  {
    void Insert(TEntity entity);
  }
}

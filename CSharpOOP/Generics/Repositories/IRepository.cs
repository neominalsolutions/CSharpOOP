using CSharpOOP.Generics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Generics.Repositories
{

  public interface IRepository<TEntity, TKey>
 where TEntity : Entity<TKey>
 where TKey : IComparable
  {
    void Insert(TEntity entity);
    void Delete(TKey Id);

    void Update(TEntity entity);

    TEntity Find(Predicate<TEntity> lambda);

    TEntity FindById(TKey Id);

    IEnumerable<TEntity> Where(Func<TEntity, bool> lambda); // x=> x.Name.StartsWith('a'); lambda

    IEnumerable<TEntity> FindAll();

  }
}

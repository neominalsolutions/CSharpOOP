using CSharpOOP.Generics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSharpOOP.Generics.Repositories
{
  

  public abstract class InMemoryRepository<TEntity, TKey> : IRepository<TEntity, TKey>
  where TEntity : Entity<TKey>
  where TKey : IComparable
  {
    protected List<TEntity> entities = new List<TEntity>(); // Collections Generic List en yaygın kullanılan

    public virtual void Delete(TKey Id)
    {
      var entity = FindById(Id);
      entities.Remove(entity);
    }

    public virtual TEntity Find(Predicate<TEntity> lambda)
    {
      return entities.Find(lambda);
    }

    public virtual IEnumerable<TEntity> FindAll()
    {
      return entities.ToList();
    }

    public virtual TEntity FindById(TKey Id)
    {
      var entity = entities.Find(x => x.Id.Equals(Id));

      if(entity is not null)
      {
        return entity;
      } 
      else
      {
        throw new Exception("Entity Not Found");
      }
     
    }

    //public abstract void Insert(TEntity entity);
    public virtual void Insert(TEntity entity)
    {
      entities.Add(entity);
    }

    public virtual void Update(TEntity entity)
    {
      var item = FindById(entity.Id);

      // var itemEntity = item.Clone(); // listedeki referansı koptu;
      item = entity;

      Console.WriteLine("entity" + JsonSerializer.Serialize(item)); // Json string formatında nesneyi yazar.s

    }

    public virtual IEnumerable<TEntity> Where(Func<TEntity, bool> lambda)
    {
      return entities.Where(lambda);
    }
  }


  
}

using CSharpOOP.Generics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSharpOOP.Generics.Repositories
{
  public class PostRepository:InMemoryRepository<Post,int>
  {
    // Proxy Class özelliği görüyor
    // Base sınıfa ait implementasyonlar gerçekleşmeden önce burası tatiklenerek ara işlemler yapılabilir.
    public override void Insert(Post entity)
    {
      base.Insert(entity);
    }

    public override void Update(Post entity)
    {

      var item = entities.Find(x => x.Id == entity.Id);

      // 1. güncelleme yöntemi
      //item.Title = entity.Title;
      //item.Body = entity.Body;

      //2. güncelleme yöntemi
      var itemCopy = item.Clone() as Post;
      itemCopy = entity.Clone() as Post;

      Console.WriteLine("itemCopy" + JsonSerializer.Serialize<Post>(itemCopy));

      //base.Update(entity);
    }
  }
}

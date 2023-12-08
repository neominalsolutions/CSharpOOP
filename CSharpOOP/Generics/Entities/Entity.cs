using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Generics.Entities
{
    // Tkey IComparable denilen interfaceden implemente olacak şekilde tanımlayarak code defensing sağlayacağız.
    public abstract class Entity<TKey>
      where TKey : IComparable
    {
        public TKey Id { get; init; }

       
        // Nesnenin referanslarını kopararak içindeki değerleri kopyalamamızı sağlar.
       public virtual Entity<TKey> Clone()
       {
          return (Entity<TKey>)MemberwiseClone();
       }
        


    }
}

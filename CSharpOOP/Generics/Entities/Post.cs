using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Generics.Entities
{
    public class Post : Entity<int>
    {
        public Post()
        {
            Id = 1;
        }

    public string Title { get; set; }
    public string Body { get; set; }

    public override Entity<int> Clone()
    {
      return (Post)MemberwiseClone();
    }

  }
}

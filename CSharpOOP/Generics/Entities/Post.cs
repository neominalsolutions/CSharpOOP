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
    }
}

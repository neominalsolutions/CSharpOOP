using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Generics.Entities
{



    public class Author : Entity<long>
    {
        public Author()
        {
            Id = long.MaxValue;
        }
    }
}

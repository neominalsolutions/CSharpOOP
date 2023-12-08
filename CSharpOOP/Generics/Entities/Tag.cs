using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Generics.Entities
{
    public class Tag : Entity<Guid>
    {
        public Tag()
        {
            Id = new Guid();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Generics.Entities
{
    public class Comment : Entity<string>
    {
        public Comment()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}

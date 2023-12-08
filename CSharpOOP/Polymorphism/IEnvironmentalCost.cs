using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Polymorphism
{
  public interface IEnvironmentalCost
  {
    double EnviromentCost { get; init; }
    void Do();
  }
}

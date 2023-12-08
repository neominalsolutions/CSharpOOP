using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Polymorphism
{
  public interface IEnergyConsumptionCost
  {
    double EnergyConsumptionCost { get; init; }
    void Do();
  }
}

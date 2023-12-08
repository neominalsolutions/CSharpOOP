using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Polymorphism
{
  // WaterBill is a Bill => Inheritance (sahipliğe bakar), class yada abstract class
  // WaterBill has a EnvironmentCost  => Interface (yeteneğe bakar)
  public class WaterBill : Bill, IEnvironmentalCost
  {
    public double EnviromentCost { get; init; }

    public WaterBill(double firstIndex, double lastIndex, double unitPrice, double enviromentCost) : base(firstIndex, lastIndex, unitPrice)
    {
      EnviromentCost = enviromentCost;
    }

    // class polymorphism
    // abstract olarak işaretlenmiş üyeleri ovveride etmek zorundayız.
    public override double CaculateUsageCost()
    {
     return ((FirstIndex - LastIndex) * UnitPrice) + EnviromentCost;
    }

    public void Do()
    {
      throw new NotImplementedException();
    }

    // virtual olarak işaretlenmiş methodları ovveride etme zorunluluğumuz yok
    public override double GetBaseUsageCost()
    {
      return base.GetBaseUsageCost() + EnviromentCost;
    }
  }
}
 
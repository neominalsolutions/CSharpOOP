using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Polymorphism
{
  // IEnergyConsumptionCost Elektrik faturası içinde kullanılacak bir özellik
  // IEnvironmentalCost Elektirik,Su,Doğal Gaz faturası için kullanılacak bir özellik
  // Not: Birbiriden farklı sınıflara interface vasıtası ile aynı özellikler kazandırılıp, tek bir çatı altında benzer standart kod yazım teknikleri uygulanabilir. Interface ile yeteneklerin dağıtımı her bir sınıf için farklı şekillerde gerçekleşeceğinden dolayı interface yolu ile polymorphism sağlanmış olur. 
  public class NaturalGasBill : Bill, IEnvironmentalCost, IEnergyConsumptionCost
  {
    public double EnviromentCost { get; init; }
    public double EnergyConsumptionCost { get; init; }


    public NaturalGasBill(double firstIndex, double lastIndex, double unitPrice, double environmentCost, double energyConsumptionCost) : base(firstIndex, lastIndex, unitPrice)
    {
      EnviromentCost = environmentCost;
      EnergyConsumptionCost = energyConsumptionCost;
    }

    public override double CaculateUsageCost()
    {
      return ((LastIndex - FirstIndex) * UnitPrice) + (EnergyConsumptionCost + EnergyConsumptionCost);
    }

    void IEnvironmentalCost.Do()
    {
      Console.WriteLine("IEnvironmentalCost.Do");
    }

    void IEnergyConsumptionCost.Do()
    {
      Console.WriteLine("IEnergyConsumptionCost.Do");
    }


  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Polymorphism
{
  public abstract class Bill // Faturan firstIndex LastIndex'ine ve unitPrice göre bir hesaplama yapıp sonuç döndüreceğimizden dolayı ve bu hesaplamayı Bill fatura sınıfında bilmediğimizden dolayı abstract tercih ettik.
  {
    protected double FirstIndex { get; init; }
    protected double LastIndex { get; init; }
    protected double UnitPrice { get; init; }

    public Bill(double firstIndex,double lastIndex, double unitPrice)
    {
      FirstIndex = firstIndex;
      LastIndex = lastIndex;
      UnitPrice = unitPrice;
    }
    /// <summary>
    /// Fatura Kullanım Tutarı Hesapla
    /// İşin nasıl yapılacağını bilmediğimizde CaculateUsageCost methodunu kalıtım alınan sınıflarda ovveride edip kendi logicimizi yazıcaz
    /// </summary>
    /// <returns></returns>
    public abstract double CaculateUsageCost();

    // Basede bir hesaplama yapılmış fakat yapılan bu hesaplama kalıtım alan sınıflarda ovveride edilere farklı bir davranış için kullanılabilir.
    public virtual double GetBaseUsageCost()
    {
      return (LastIndex - FirstIndex) * UnitPrice;
    }
  }
}

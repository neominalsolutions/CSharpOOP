using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Inheritance
{
  // çoklu multiple inheritance diamond problem'a sebep olur. aynı isimdeki özelliklerden hangisini sınıfa aktaracağını bilemez.
  public class Employee : Person
  {
    public string SocialNumber { get; init; }

    public Employee(string firstName, string lastName, string socialNumber) : base(firstName, lastName)
    {
      SocialNumber = socialNumber;
    }
  }

  // Manager hem Person kalıtım almış hemde Employee sınıfından kalıtım almış olur.
  public class Manager : Employee
  {
    public Manager(string firstName, string lastName, string socialNumber) : base(firstName, lastName, socialNumber)
    {
    }
  }
}

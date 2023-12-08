using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Inheritance
{
  public abstract class Person // somut sınıflara yol gösterici ama program tarafında db de direk olarak tutulmayacak bir çok projede referans alacağımız bir soyut sınıf yarattık.
  {
    public string FirstName { get; init; }
    public string LastName { get; init; } // bir sınıfta zorunlu olarak kullanılması gereken alanlar her zaman constructor üzerinden parametre olarak geçilmelidir.

    public string FullName
    {
      get
      {
        return $"{this.FirstName} {this.LastName}";
      }
    }
    public Person(string firstName,string lastName)
    {

      // validayon gözümünden kaçarsa burada yanlış bir nesne instance almamak için exception case yazabilir.z
      if (string.IsNullOrEmpty(firstName) || string.IsNullOrWhiteSpace(firstName))
      {
        throw new Exception("FirstName değeri girilmesi gerekir.");
      }

      FirstName = firstName.Trim();
      LastName = lastName.Trim().ToUpper();
    }

  }
}

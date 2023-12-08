using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Abstraction
{

  // Uygulama içerisinde ihtiyacımız olan kod bloklarının özetlerini önceden çıkarak abstraction yapmış olduk.
  public interface IEncrptor
  {
    string Encrypt(string plaintText); // şifreleme yap döndür
  }
}

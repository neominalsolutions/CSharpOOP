using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Abstraction
{
  // Sadece şifrelenebilir.
  // Interfaceler olabildiğince küçük atomik paraçlarda yetenek vermek için kullanılmalıdır. classlar interface methodlarının implemente etmeyi zorlandığından dolayı gereksiz atıl kod blokları ile uğraşmak zorunda kalırız.
  // Not: interfacler birbirin sonsuz sayıda implemente olabildiği için interfacleri saran wrapper interface yapıları sonradan kurulabilir.
  public class HashCryptoService : IEncrptor
  {
    // Dummy Code, Atıl kod.
    //public string Decrypt(string chipherText)
    //{
    //  throw new NotImplementedException();
    //}

    public string Encrypt(string plaintText)
    {
      // Hash algoritması yazılacak
      throw new NotImplementedException();
    }
  }
}

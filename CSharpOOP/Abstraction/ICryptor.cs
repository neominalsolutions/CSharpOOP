using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Abstraction
{
  // Hem çözme hemde şifrelem işlemi yapar.
  // Wrapper interface görevi gördü
  public interface ICryptor:IEncrptor,IDecriptor
  {
    //string Encrypt(string plaintText); // şifreleme yap döndür
    //string Decrypt(string chipherText); // şifrelenmiş text
    public string SharedKey { get; init; }
  }
}

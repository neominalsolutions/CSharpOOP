using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Abstraction
{
  public class AESCryptoService : ICryptor /*IEncrptor,IDecriptor*/
  {
    public string SharedKey { get; init; }

    public AESCryptoService(string sharedKey)
    {
      SharedKey = sharedKey;
    }

    public string Decrypt(string chipherText)
    {
      throw new NotImplementedException();
    }

    public string Encrypt(string plaintText)
    {
      // simetrik bir key ile şifreleme algoritması yazılacak
      throw new NotImplementedException();
    }
  }
}

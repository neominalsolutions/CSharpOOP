using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Encapsulation
{
  public class Customer
  {
    // init ile değerleri contructordan almaya zorluyoruz
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string Id { get; init; }
    public Customer(string firstName, string lastName)
    {
      FirstName = firstName.Trim();
      LastName = lastName.Trim().ToUpper();
      Id = Guid.NewGuid().ToString();
      // Encapsulation var.
    }
    // Müşterinin sahip olduğu hesaplar.
    private List<Account> accounts { get; set; } = new List<Account>();

    // Hesap açılış işlemi
    public void OpenAccount(string accountNumber)
    {
      // kontrollü bir account ekleme işlemi
      // class encapsulation var.
      var account = new Account(accountNumber);
      accounts.Add(account);
    }
    // Hesap kapama işlemi
    public void CloseAccount(string closeReason, string accountNumber)
    {
      var account = this.accounts.Find(x => x.AccountNumber == accountNumber);

      if(account is not null)
      {
        // account Close method account içerisinde encapsulation edilmiştir.
        account.Close(closeReason);
      }
    }

    // Musterinin şuanki hesabı
    public Account? GetCurrentAccount(string accountNumber)
    {
      // account listesini private yapıp dışarı method olarak açtık.
      var account = this.accounts.Find(x => x.AccountNumber == accountNumber);
      return account;
    }


  }
}

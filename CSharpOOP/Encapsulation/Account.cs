using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Encapsulation
{
  public class Account
  {
    public string AccountNumber { get; init; }
    public decimal Balance { get; private set; } // class içinden sadece set edilebilsin
    public bool IsClosed { get; private set; } // false
    public string? CloseReason { get; private set; } = ""; // default değer ataması yaptık.
    public DateTime? ClosedDate { get; set; }

    public Account(string accountNumber)
    {
      AccountNumber = accountNumber;
      Balance = 0;
      IsClosed = false;
    }

    public void Close(string closeReason)
    {
      // Encapsulation işlemi.
      CloseReason = closeReason;
      IsClosed = true;
      ClosedDate = DateTime.Now;
    }
  }
}

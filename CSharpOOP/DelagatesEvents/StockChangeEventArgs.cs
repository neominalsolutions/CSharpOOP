using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.DelagatesEvents
{
  public class StockChangeEventArgs:EventArgs
  {
    public int OldStock { get; set; }
    public int NewStock { get; set; }

  }
}

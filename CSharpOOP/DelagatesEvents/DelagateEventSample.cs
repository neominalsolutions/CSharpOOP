using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.DelagatesEvents
{

  public delegate void MessageDelegate(string message); // bu imzaya sahip tüm methodlar delegate tarafından excute edilebilir.
  public delegate void ShowMessageDelegate(string message,int timeOut);

  public class DelagateEventSample
  {
 

    public  void Sample()
    {
      MessageDelegate m1 = LogMessage;
      MessageDelegate m2 = ConsoleMessage;
      //ShowMessageDelegate m3 = ShowMessage;

      m1("message1");
      m2("message2");
      //m3("message3", 1);
    }

    public void ShowMessage(string message, int timeOut)
    {

    }

    public static  void LogMessage(string message)
    {
      Console.Write(message);
    }

    public static void ConsoleMessage(string message)
    {
      Console.WriteLine(message);
    }

  }
}

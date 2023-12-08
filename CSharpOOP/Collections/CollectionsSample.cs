using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Collections
{
  public static class CollectionsSample
  {

    // Dictionary
    // key value cinsinden unique key değerleri ile çalışmamız gerekebilir.

    public static void DictionarySample()
    {
      IDictionary<string, int> scores = new Dictionary<string, int>();
      scores["Ali"] = 50;
      scores["Can"] = 70;
      scores["Mustafa"] = 100;

      scores.Add(new KeyValuePair<string, int>("Hakan", 10));

      // scores["Ali"] = 50; // aynı key tanımı yapılamaz key değerli unique olarak tutulur.

      scores.ContainsKey("Ali"); // key kontrolü

      foreach (KeyValuePair<string,int> item in scores)
      {
        Console.WriteLine("Key" + item.Key + "Value" + item.Value);
      }

    }

    // 100 $
    public class Money // ValueObject
    {
      public double Amount { get; init; }
      public string Currecy { get; init; }

      public Money(double amount, string currency)
      {
        Amount = amount;
        Currecy = currency;
      }

    }

    public static void HashSetSample()
    {
      // HashSet koleksiyon yapıları içerisinde unique object referansa göre çalışan yapılar.

      HashSet<Money> monies = new HashSet<Money>();
      var m1 = new Money(10, "$");
      var m2 = new Money(20, "TL");
      var m3 = new Money(10, "$"); // referans değer farklı olduğu için bunu listeye ekledi

      monies.Add(m1);
      monies.Add(m2);
      monies.Add(m3);

      Console.WriteLine("monies : " + monies.Count);

      
    }

    // Stack ve Queue

    public static void StackQueueSample()
    {
      // LIFO (Last In First Out) ve FIFO (First In First Out) mantıklı çalışır.
      Stack<int> slist = new Stack<int>();
      slist.Push(1); // JS array yapıları stack mantığında çalışır
      slist.Pop(); // ilk elemanı listeden siler.
      slist.Peek(); // listedeki ilk elemanı döndürür. silmeden döner

      Queue<string> names = new Queue<string>();
      names.Peek();
      names.Enqueue("ali"); // sıraya al
      names.Dequeue(); // sıradan çıkar ilk elemanı

    }


  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;




namespace CSharpOOP.DelagatesEvents
{
  public delegate void ProductStockChangeHandler (Product p, StockChangeEventArgs args);

  public class Product
  {
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    public event EventHandler StockChanged; // dili geçmiş zaman tipinde tanımlarız. Eventleri çalıştırmak için bir en az 1 delegate ihtiyacımız var.
    // EventHandler Net Framework object tipinde değer döndüren bir delegate tanımı

    public event ProductStockChangeHandler CustomStockChanged;

    public Product()
    {
      CustomStockChanged += CustomStockStatusChange; // event listener tanımlaması yani burası ShowStatus dinleyecek.
      // ShowStatus = ShowStatus.bind(this)
    }


    public void IncreaseStock(int value)
    {
      int newStock = Stock + value;
      int oldStock = Stock;
      Stock = newStock;

      // bu değerleri olay gerçekleştiğinde fırlat dedik.
      var @eventArgs = new StockChangeEventArgs { OldStock = oldStock, NewStock = newStock };


      StockChanged.Invoke(this, @eventArgs); // delagate devreye girip EventHandler üzerinde bu evente tanımlanmış methodu çalıştıracak
      CustomStockChanged.Invoke(this, @eventArgs);
    }

    public void DecreaseStock(int value)
    {
      int newStock = Stock - value;
      int oldStock = Stock;
      Stock = newStock;

      var @eventArgs = new StockChangeEventArgs { OldStock = oldStock, NewStock = newStock };
      StockChanged.Invoke(this, @eventArgs); // delagate devreye girip EventHandler üzerinde bu evente tanımlanmış methodu çalıştıracak
      CustomStockChanged.Invoke(this, @eventArgs);
    }

    // Delegate ile aynı imzaya sahip bir method tanımı yaptım.
    private void CustomStockStatusChange(Product sender, StockChangeEventArgs args)
    {
      var data = args as StockChangeEventArgs;

      Console.WriteLine(JsonSerializer.Serialize<StockChangeEventArgs>(data));
    }

  }
}

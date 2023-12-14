// See https://aka.ms/new-console-template for more information
using CSharpOOP.Abstraction;
using CSharpOOP.Collections;
using CSharpOOP.DelagatesEvents;
using CSharpOOP.Encapsulation;
using CSharpOOP.Generics.Entities;
using CSharpOOP.Generics.Repositories;
using CSharpOOP.Inheritance;
using CSharpOOP.OtherTypes;
using CSharpOOP.Polymorphism;
using CSharpOOP.Serialization;
using CSharpOOP.Streams;
using System;
using System.Data;
using System.Reflection;

Console.WriteLine("Hello, World!");


#region Encapsulation

/*

// OOP 4 temel ilkemiz var
// 1. Encapsulation (classlar içerisinde akışı gizli tutma)

var customer = new Customer("ali", "tan");
// customer.FirstName = "Mustafa"; code-defensing

customer.OpenAccount("24324-234324-234324");
customer.CloseAccount("Kredi ödemesini bitirdim", "24324-234324-234324");
var acc = customer.GetCurrentAccount("24324-234324-234324");
// acc.Balance = 100;

*/

#endregion


#region InHeritance

/*

// 2. Inheritance   (ortak özelliklerin aktarımı, reusability)

// Kalıtım developer'a aynı standartlar altında kod yazma becerisi kazandırır.
// uygulamaya kolay adapte olmamızı sağlar.
// bir çok yerde fazladan gereksiz kod blogu yazmaktan kurtulmuş oluruz.

var manager = new Manager("Ali", "Tan", "324324-34432");
string fullName = manager.FullName;

var employee = new Employee("Ali", "Tan", "234243324-23432");
string fullName2 = employee.FullName;

*/

#endregion


#region Polymorphism

/*

// 3. Polymorphism  (çok biçimlilik, bir sınıfın yapacağı işlemleri farklı şekillerde de yapabilme kabiliyetini olması gerek. extensibility, bir kodun başka davranışlara adapte olabilme becerisi)


var gasBill = new NaturalGasBill(100, 500, 5, 25, 100);

// aynı methoda sahip interfacelerden implemente olan sınıfın interface methodlarını çağırma şekli 
((IEnergyConsumptionCost)gasBill).Do(); // gasBill sınıfını bu yetenek ile kullan.
((IEnvironmentalCost)gasBill).Do();
((Bill)gasBill).CaculateUsageCost(); // abstract bir üye olması sebebi ile ovveride edilen yerden kod blogunu çalıştırır.
gasBill.CaculateUsageCost();


Bill waterBill = new WaterBill(100,500,5,25);
waterBill.CaculateUsageCost();

// Not: Eğer ki base bir sınıfın özelliği kullanacak isek sınıfın içindeki detaylara boğuşmamk için kalıtım altığımız sınıfın class şablonu ile çalışabilir. yukarıdaki kod blogu ile aşağıdaki kod blogu aynıdır.

WaterBill wb = new WaterBill(100, 500, 5, 25);
wb.CaculateUsageCost();

var wbt = new WaterBill(100, 500, 5, 13);


if(gasBill is Bill)
{
  Console.WriteLine("gasBill is Bill");
}

// is ve as keyword is tip kontrolü (type check) yapar, as (type conversion) ise tip dönüşümü yapar.
// (Bill)gasBill casting işlemi (unboxing işlem type conversion)

if (gasBill is IEnergyConsumptionCost) // type check
{

  // 1. kullanım
  ((IEnvironmentalCost)gasBill).Do(); // casting

  // 2.kullanım şekli
  var energyGassBill = gasBill as IEnvironmentalCost; // unboxing
  energyGassBill.Do();
  
  Console.WriteLine("gasBill is IEnergyConsumptionCost");
}

if(gasBill is IEnvironmentalCost)
{
  Console.WriteLine("gasBill is IEnvironmentalCost");
}

*/

#endregion


#region Abstraction
/*

// 4. Abstraction (özetleme, soyutlama, yapılacak bir işlemin önce özetinin çıkarılması, detaylarının sonraya bırakılması)



ICryptor cryptor = new AESCryptoService("324324");
cryptor.Decrypt("sfsadsad");
cryptor.Encrypt("324234324"); // Simetrik Kriptografi yapar

IEncrptor enc = new HashCryptoService();
enc.Encrypt("32434324"); // Hash kriptoğrafi yapar.

*/

#endregion


// Generic Class Sample

#region GenericClass

/*

var postRepo = new PostRepository();
postRepo.Insert(new CSharpOOP.Generics.Entities.Post { Title = "Makale1", Body = "Makale İçerik" });
var list = postRepo.Where(x => x.Title == "Makale1").ToList();
var updateItem = new Post();
updateItem.Title = "Makale2";
updateItem.Body = "Makale 2 İçerik";
postRepo.Update(updateItem);
var c = postRepo.Find(x => x.Title.StartsWith("M"));
postRepo.Delete(1);

var data = postRepo.FindAll();


Console.ReadKey();

*/

#endregion



#region Collections

CollectionsSample.HashSetSample();


#endregion



#region Delegates


var myclass = new DelagateEventSample();

MethodInfo[] methodInfos = myclass.GetType().GetMethods();

// runtimede yakalan sınıfa ait methodlar aşağıdaki MessageDelegate üzerinden invoke edilir.

foreach (MethodInfo item in methodInfos)
{
  if(item.IsStatic)
  {
    var dg = item.CreateDelegate<MessageDelegate>();
    dg.Invoke("Deneme1");
  }


}


// Events Sample

var product = new Product();
product.Price = 25;
product.ProductName = "Ürün-1";
product.Stock = 25;
product.StockChanged += Product_StockChanged;

product.IncreaseStock(10);
product.DecreaseStock(5);

void Product_StockChanged(object? sender, EventArgs e)
{

}

#endregion

#region OtherTypes

OtherTypes.ExtensionSample();
OtherTypes.RegexSample();
OtherTypes.RecordSample();
OtherTypes.TuppleSample();

#endregion


#region Serialization

Serialization.NewtonSoftSample();
Serialization.SystemTextJson();


#endregion


#region Streams

Streams.StreamWriterReader();
Streams.FileStreamWriterReader();

#endregion


// Serialization NewtonSoftJson ve System.Text.Json
// Extension, Regex, Tupple, Record
// Stream StreamReader StreamWriter ve FileStream yapılarını inceleyeceğiz.

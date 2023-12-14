using CSharpOOP.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpOOP.OtherTypes
{

  // JS deki Prototype dediğimiz yapıya benzer bir geliştirme şekli
  // C# extension class
  // extension class static olmak zorundadır.
  // extend edilecek tip örnekteki gibi this kwyword ile belirtilmelidir ExtensionSample.Person person
  // zaten static class olmasından ötürür static method tanımı yapılmalıdır.

  public static class PersonExtension
  {
    public static string FullName(this ExtensionSample.Person person)
    {
      person.FirstName.Trim();
      person.LastName.Trim();

      return $"{char.ToUpper(person.FirstName[0]) + person.FirstName.Substring(1)} {person.LastName.ToUpper()}";
    }
  }

  public record PersonRecord
  {
    public string FirstName { get; init; }
    public string LastName { get; init; }

    public PersonRecord(string firstName,string lastName)
    {
      FirstName = firstName.Trim();
      LastName = lastName.Trim();
    }


  }

  public static class OtherTypes
  {
    // Extension bir sınıfın genişletilipi yeni özellikler eklenerek kullanılmasını sağlayacak bir geliştirme yöntemi.
    // genelde class müdahale etmeden direk tip üzrinden yapmamıza imkan tanır. 

    public static void ExtensionSample()
    {
      ExtensionSample.Person p = new ExtensionSample.Person("Ali","Tan");
      Console.WriteLine(p.FullName());
    }

    public static void RegexSample()
    {
      string input = "is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";

      // kaç adet kelime var.
      string wordPattern = @"\b\w+\b";

      MatchCollection matches = Regex.Matches(input, wordPattern);
      Console.WriteLine("Bulunan Kelime Adet" +matches.Count);
      string replacedText = Regex.Replace(input, "Lorem", "Lrm");

      // 3.özellik ise elimizde regex ile eşleşen bir tanımlama yaptık mı kontrolü
      string password = "MyP@ssw0rd";

      // güvenli parola formatı
      // En az 8 karakter uzunluğunda olmalıdır.
      // En az bir harf(büyük veya küçük), bir rakam ve bir özel karakter(@, $, !, %, *, ?, &) içermelidir.

      string pattern2 = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

      if(Regex.IsMatch(password,pattern2))
      {
        Console.WriteLine("Parola eşleşiyor");
      }



    }
  
  
    // C# 9.0 ile birlikte record dediğimiz bir referans tip kullanıma sunuldu
    // aslı çıkış sebebi classların referanslar üzerinden eşitlik durumları için kullanılması class içerisindeki değerlerin eşitliğini kontrol edecek bir yapının olmamasıydı. Referans olarak tanımlanmış ama value eşitliğine bakılan durumlar için kullanımı mantıklı. ValueObject


    // class tiplerimi mutable type
    public static void RecordSample()
    {
      // Immutable type olarak genelde kullanılır.
      // Immutable typelarda değerler initialize aşamasında verilir ve hiç bir zaman değer değişmez.
      // DTOlarda record olarak tanımlanmak için uygundur.

      ExtensionSample.Person p = new ExtensionSample.Person("Ali", "Tan"); // farklı bir referans
      ExtensionSample.Person p2 = new ExtensionSample.Person("Ali", "Tan"); // farklı bir referans

      string result = p.Equals(p2) == true ? "evet" : "hayır";
      Console.WriteLine($"nesne refrans eşit mi {result}"); // çıktıyı false olarak döner.

      // isim soyismi benzer kişileri bul algoritmasında 
      bool isExists = p.FirstName == "Ali" && p.LastName == "Tan";

      // record ile kullanım örneği

      var p3 = new PersonRecord("Ali", "Tan");
      var p4 = new PersonRecord("Ali", "Tan");

      Console.WriteLine("record equals: " + p3.Equals(p4));

    }

    //c# 7 yada 8.0 ile gelen yapı
    public static void TuppleSample()
    {
      // birden falza farklı tipi içerisinde barındıran wrapper görevi gören bir değer tipi.

      ExtensionSample.Person p = new ExtensionSample.Person("Ali", "Tan");

      var wrapper = Tuple.Create<string, int, double, bool, ExtensionSample.Person>("ali",1,5.0,true,p);
      string item1 = wrapper.Item1;

      // ViewModel => birden fazla Entity görüntüsünü view'e yansıtırken entity içerisindeki propertyleri ViewModel yada DTO sınıfları içine çekerken Tupple kullanılabilir.
      // Birden fazla değeri alıp tek bir response olarak kullandığımız bir yapı. ASPNET MVC Model View veya WEB API DTO yapıları için.

      // 2. bir tanımlama şekli
      var person = ("Halil", "Kara", 25);
      string firstName = person.Item1;
     


      // 3. Kullanım şekli değerlere isim atamaları yaparak kullanma şekli
      var myPerson = GetPersonInfo("Ali", "Can", 45);
      string firstname = myPerson.FirstName;

      Console.WriteLine("firstName" + firstname);


    }

    // (string FirstName,string LastName,int Age) dönüş tipi
    public static (string FirstName,string LastName,int Age) GetPersonInfo(string firstname,string lastname,int age)
    {
      return (firstname, lastname, age);
    }



  
  }
}

using ExtensionSample;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSharpOOP.Serialization
{
  public static class Serialization
  {

    public static void NewtonSoftSample()
    {

      var p = new ExtensionSample.Person("Ali","Can", DateTime.Now.AddYears(-30));

      var serializerSettings = new JsonSerializerSettings
      {
        DateFormatHandling = DateFormatHandling.IsoDateFormat,
        NullValueHandling = NullValueHandling.Ignore, // Null değerleri ignore et json olarak çıktıya yansıtma
        Formatting = Formatting.Indented, // Okunaklı Json çıktısı ver
        ContractResolver = new CamelCasePropertyNamesContractResolver(), // json çıktısını camelCase yap.
        ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
      };

      string jsonString = JsonConvert.SerializeObject(p,serializerSettings);
      Console.WriteLine(jsonString);


      var person = JsonConvert.DeserializeObject<ExtensionSample.Person>(jsonString,serializerSettings);


    }

    public static void SystemTextJson()
    {

      var e = new ExtensionSample.Employee("Ali", "Can", DateTime.Now.AddYears(-30));

      var settings = new JsonSerializerOptions
      {
        DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull, // null değer ignore
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase, 
        PropertyNameCaseInsensitive = true,
        WriteIndented = true, //  Formatting.Indented bunun karşılıı
        IncludeFields = false // class içinde sadece property alır field almaz

      };

      var jsonString = System.Text.Json.JsonSerializer.Serialize(e, settings);

      var emp = System.Text.Json.JsonSerializer.Deserialize<ExtensionSample.Employee>(jsonString, settings);
        

    }

  }
}

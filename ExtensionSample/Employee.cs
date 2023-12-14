using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExtensionSample
{
  // System.Text.Json için kullanacağız
  public class Employee 
  {
    [JsonPropertyName("first_name")]
    [JsonPropertyOrder(1)]
    public string FirstName { get; init; }


    public string LastName { get; init; }

    //[JsonIgnore]
    public DateTime DateOfBirth { get; private set; }

    [JsonPropertyOrder(2)]
    [JsonPropertyName("_age")]
    public int Age { get { return DateTime.Now.Year - DateOfBirth.Year; } }


    public string? Title { get; set; }

    [JsonConstructor]// birden fazla constructor olduğu durumda hangi constructor üzerinden deserialize edeceğini belirttik.
    public Employee(string firstName, string lastName, DateTime dateOfBirth)
    {
      FirstName = firstName;
      LastName = lastName;
      DateOfBirth = dateOfBirth;
    }


  }

  
}

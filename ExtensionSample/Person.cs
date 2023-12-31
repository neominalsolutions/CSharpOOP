﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtensionSample
{
  public class Person
  {
    [JsonProperty("_first_name")]
    public string FirstName { get; init; }
    public string LastName { get; init; }

    [JsonIgnore]
    public DateTime DateOfBirth { get; private set; }
    public int Age { get { return DateTime.Now.Year - DateOfBirth.Year; } }

    public string? Title { get; set; }

    public Person(string firstName, string lastName)
    {
      FirstName = firstName;
      LastName = lastName;
    }


    [JsonConstructor]// birden fazla constructor olduğu durumda hangi constructor üzerinden deserialize edeceğini belirttik.
    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
      FirstName = firstName;
      LastName = lastName;
      DateOfBirth = dateOfBirth;
    }

  }
}

using System;

namespace DatingProfile
{ 
  class Profile
  { 
  private string name;
  private int age;
  private string city;
  private string country;
  private string pronouns;
  private string[] hobbies;
  }

  public Profile(int age, string city, string country, string pronouns = "they/them", string[] hobbies)
  {
    this.age = age;
    this.city = city;
    this.country = country;
    this.pronouns = pronouns;
    this.hobbies = hobbies;
  }
}

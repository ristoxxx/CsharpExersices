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
  

  public Profile(string name, int age, string city, string country, string pronouns = "they/them")
  {
    this.name = name;
    this.age = age;
    this.city = city;
    this.country = country;
    this.pronouns = pronouns;
    this.hobbies = new string[0];
  }
  public string ViewProfile()
  {
    string hobbyList ="";
    foreach (string hobby in hobbies)
    {
      hobbyList += $"{hobby},\n\t";
    } 
    string test = ($"Name: {name},\nAge: {age},\nCity: {city},\nCountry: {country},\nPronouns: {pronouns},\nHobbies: {hobbyList}");
    return test;
  }
  public void SetHobbies(string[] hobbies)
  {
    this.hobbies = hobbies;
  }
  }
}

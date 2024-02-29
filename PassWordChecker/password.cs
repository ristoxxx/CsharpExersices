using System;

namespace PasswordChecker
{
  class Program
  {
        // Main method to validate the strength of a password based on its length and character composition.
    public static void Main(string[] args)
    {
      int minLength = 8;
      int score = 0;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "1234567890";
      string specialChars = "!#¤%&/()=?`´+-*/";
      Console.WriteLine("Enter password: ");
      string password = Console.ReadLine();
      if (password.Length >= minLength) {
        score++;
      } 
      if (Tools.Contains(password,uppercase)) {
        score++;
      }
      if (Tools.Contains(password,lowercase)) {
        score++;
      }
      if (Tools.Contains(password,digits)) {
        score++;
      }
      if (Tools.Contains(password,specialChars)) {
        score++;
      }
      switch(score) {
        case 1:
        Console.WriteLine("Weak");
        break;
        case 2:
        Console.WriteLine("Medium");
        break;
        case 3:
        Console.WriteLine("Strong");
        break;
        case 4:
        case 5:
        Console.WriteLine("Extremely strong");
        break;
        default:
        Console.WriteLine("None");
        break;
      }


      //Console.WriteLine(score);
    }
  }
}

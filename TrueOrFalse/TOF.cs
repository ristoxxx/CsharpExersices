using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);
      string[] questions = {"Was the Statue of Liberty built in 1880?","Is tomatoes fruit?","Is the Earth flat?"};
      bool[] answers = {true, false, true};
      bool[] userAnswers = new bool[questions.Length];
      if (questions.Length != answers.Length) {
        Console.WriteLine("Error: The number of questions and answers do not match.");
      }
      int askingIndex = 0; // askingIndex
      foreach (string question in questions) {
          string input = "";
          bool isBool = false;
          bool inputBool = false;
          Console.WriteLine(question);
          Console.Write("True or False? ");
          input = Console.ReadLine();
          isBool = bool.TryParse(input, out inputBool);
      }

      // Type your code below
      
    }
  }
}

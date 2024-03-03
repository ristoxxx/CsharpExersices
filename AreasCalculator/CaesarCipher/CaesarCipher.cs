using System;
using System.Text.RegularExpressions;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      string message = "";
      Console.WriteLine("Enter message");
      message = Console.ReadLine().ToLower();
      char[] secretMessage = message.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];
      for (int i = 0; i < secretMessage.Length; i++) {
        char letter = secretMessage[i];
         string pattern = "abcdefghijklmnopqrstuvwxyz";
        if (!pattern.Contains(letter)) {
          encryptedMessage[i] = letter;
        } else {
        int index = Array.IndexOf(alphabet, letter);
        index = (index + 3) % 26;
        char newLetter = alphabet[index];
        encryptedMessage[i] = newLetter;
        }
        }
      string newMessage = String.Join("", encryptedMessage);
      Console.WriteLine("Encrypted message: " + newMessage);
      }
    }
  }

using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      string message = "";
      Console.WriteLine("Enter message");
      message = Console.ReadLine();
      char[] secretMessage = message.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];
      for (int i = 0; i < secretMessage.Length; i++) {
        char letter = secretMessage[i];
        int index = Array.IndexOf(alphabet, letter);
        index = index + 3;
        char newLetter = alphabet[index];
        encryptedMessage[i] = newLetter;

        }
      string newMessage = new string(string.Join(encryptedMessage));
      Console.WriteLine("Encrypted message: " + newMessage);
      }
    }
  }
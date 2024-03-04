using System;
using System.Text.RegularExpressions;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      string choice = "e";
      Console.WriteLine("Would you like to encrypt or decrypt?");
      Console.WriteLine("e for encrypt, d for decrypt");
      choice = Console.ReadLine();
      string message = "";
      Console.WriteLine("Enter message");
      message = Console.ReadLine().ToLower();
      Console.WriteLine("Enter key");
      int key = int.Parse(Console.ReadLine());
      char[] secretMessage = message.ToCharArray();
      if (choice == "e") {
          string newMessage = String.Join("", (Encrypt(secretMessage, key)));
          Console.WriteLine("Encrypted message: " + newMessage);
      } else {
          string newMessage = String.Join("", (Decrypt(secretMessage, key)));
          Console.WriteLine("Decrypted message: " + newMessage);
      }
      
    }
    static char[] Encrypt(char[] secretMessage, int key) {
        char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        char[] encryptedMessage = new char[secretMessage.Length];
        for (int i = 0; i < secretMessage.Length; i++) {
            char letter = secretMessage[i];
            string pattern = "abcdefghijklmnopqrstuvwxyz";
            if (!pattern.Contains(letter)) {
                encryptedMessage[i] = letter;
            } else {
                int index = Array.IndexOf(alphabet, letter);
                index = (index + key) % 26;
                char newLetter = alphabet[index];
                encryptedMessage[i] = newLetter;
            }
            }
        return encryptedMessage;
    }
    static char[] Decrypt(char[] secretMessage, int key) {
        char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        char[] decryptedMessage = new char[secretMessage.Length];
        for (int i = 0; i < secretMessage.Length; i++) {
            char letter = secretMessage[i];
            string pattern = "abcdefghijklmnopqrstuvwxyz";
            if (!pattern.Contains(letter)) {
                decryptedMessage[i] = letter;
            } else {
                int index = Array.IndexOf(alphabet, letter);
                index = (index - key) % 26;
                char newLetter = alphabet[index];
                decryptedMessage[i] = newLetter;
            }
        }
        return decryptedMessage;
    }

  }
}


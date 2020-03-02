using System;
using System.Collections.Generic;
using Leetspeak.Models;

namespace Leetspeak
{
 public class Program
  {
   public static void Main()
    {
      string userInput = GetUserInput();
      LeetspeakTranslator translator = new LeetspeakTranslator();
      string convertedString = translator.Translate(userInput);
      Console.WriteLine(convertedString);
    }

    public static string GetUserInput()
    {
      Console.WriteLine("enter a sentence to turn into Leetspeak:");
      string userInput = Console.ReadLine();
      return userInput;
    }
  }
}
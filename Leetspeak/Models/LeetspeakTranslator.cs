using System;
using System.Collections.Generic;

namespace Leetspeak.Models
{
  public class LeetspeakTranslator
  {
    public string Translate(string input)
    {
      char[] inputArr = input.ToCharArray();
      for(int i =0; i<inputArr.Length; i++)
      {
        if(inputArr[i] == 'e'|| inputArr[i] == 'E')
        {
          inputArr[i] = '3';
        }
        else if(inputArr[i] == 'o' || inputArr[i] == 'O')
        {
          inputArr[i] = '0';
        }
        else if(inputArr[i] == 'I')
        {
          inputArr[i] = '1';
        }
        else if (inputArr[i] == 't' || inputArr[i] == 'T')
        {
          inputArr[i] = '7';
        }
      }

      string inputString = new String(inputArr);
      string[] inputWordArr = inputString.Split(" ");

      string[] reconstructedInput = new string[inputWordArr.Length];
      for (int j = 0; j<inputWordArr.Length; j++)
      {
        char[] tempWordArr = inputWordArr[j].ToCharArray();
        for (int i=1; i< tempWordArr.Length; i++)
        {
          if (tempWordArr[i] == 's' || tempWordArr[i] == 'S')
          {
            tempWordArr[i] = 'z';
          }
        }
          string reconstructWord = new String(tempWordArr);
          reconstructedInput[j] = reconstructWord;
      }
      string convertedString = String.Join(" ", reconstructedInput);
      return convertedString;
    }
  }
}
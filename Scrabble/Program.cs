using System;
using Scrabble.Models;

namespace Scrabble
{
  public class Program
  {
    static void Main()
    {
      System.Console.WriteLine("We're going to start the Scrabble game...");

      Word newWord = new Word("axel");
      System.Console.WriteLine(newWord.Score);
      newWord.ScoreWord();
    }
  }
}
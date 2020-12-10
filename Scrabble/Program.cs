using System;
using Scrabble.Models;

namespace Scrabble
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("We're going to start the Scrabble game...");
      Console.WriteLine("Enter your word to receive your score:");
      //string userInput = Console.ReadLine();
      Word newWord = new Word(Console.ReadLine());
      newWord.ScoreWord();
      Console.WriteLine("Your word score total is " + newWord.Score);
      Console.WriteLine("Would you like to play again? Press ['Y' for yes] or ['Enter' for no");
      string playAgain = Console.ReadLine();
      if ( playAgain == "y" || playAgain == "Y")
      {
        Console.WriteLine(newWord.InPlay());
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
    }
  }
}
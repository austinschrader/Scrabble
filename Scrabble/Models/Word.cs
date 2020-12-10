using System;

namespace Scrabble.Models
{
  public class Word
  {
    public string UserInput { get; }
    public int Score { get; }
    public Word(string userInput)
    {
      UserInput = userInput;
      Score = 0;
    }

    public void ScoreWord()
    {
    for(int i = 0; i < UserInput.Length; i++)
      Console.WriteLine(UserInput[i]);
    } 
  }

}
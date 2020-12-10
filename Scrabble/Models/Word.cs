

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



    
  }
}
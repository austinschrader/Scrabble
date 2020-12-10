using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      Word newWord = new Word("axel");
      int startingScore = 0;
      Assert.AreEqual(typeof(Word), newWord.GetType());
      Assert.AreEqual(startingScore, newWord.Score);
    }

  }
}






















